using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FechamentoCaixa.Service
{
    public class MotoqueiroService
    {
        private readonly GerenciadorDatabase _db;
        public MotoqueiroService(GerenciadorDatabase db)
        {
            _db = db;
        }

        // =========================
        // CRUD
        // =========================
        public bool AdicionarMotoqueiro(Motoqueiro motoqueiro)
        {

            motoqueiro.Nome = NormalizaNome(motoqueiro.Nome);
            foreach (char c in motoqueiro.Nome)
            {
                if (char.IsDigit(c))
                    throw new ArgumentException("O nome do motoqueiro não pode conter números.");
            }
            if (_db.ExistsMotoqueiroByName(motoqueiro.Nome) || _db.ExistsMotoqueiroByName(motoqueiro.Nome + " (Extra)"))
                throw new NomeMotoqueiroJaCadastradoException();
            if (string.IsNullOrWhiteSpace(motoqueiro.Nome))
                throw new NomeVazioException();

            if (motoqueiro.Extra)
                motoqueiro.Nome += " (Extra)";
            return _db.AddMotoqueiro(motoqueiro);
        }
        public bool EditarMotoqueiro(int idMotoqueiroEditado, Motoqueiro novoMotoqueiro)
        {
            Motoqueiro motoqueiroEditado = _db.GetMotoqueiroById(idMotoqueiroEditado);
            novoMotoqueiro.Nome = NormalizaNome(novoMotoqueiro.Nome);
            foreach (char c in novoMotoqueiro.Nome)
            {
                if (char.IsDigit(c))
                    throw new ArgumentException("O nome do motoqueiro não pode conter números.");
            }
            if (_db.ExistsMotoqueiroByName(novoMotoqueiro.Nome) || _db.ExistsMotoqueiroByName(novoMotoqueiro.Nome + " (Extra)"))
                throw new NomeMotoqueiroJaCadastradoException();

            if (string.IsNullOrWhiteSpace(novoMotoqueiro.Nome))
                throw new NomeVazioException();
            if (motoqueiroEditado == null)
                throw new MotoqueiroNaoEncontradoException();
            if (motoqueiroEditado.Extra == true && novoMotoqueiro.Extra == false)
                novoMotoqueiro.Nome = novoMotoqueiro.Nome.Replace(" (Extra)", "");
            if (motoqueiroEditado.Extra == false && novoMotoqueiro.Extra == true)
                novoMotoqueiro.Nome += " (Extra)";
            if (novoMotoqueiro.Extra == true && !novoMotoqueiro.Nome.EndsWith(" (Extra)"))
                novoMotoqueiro.Nome += " (Extra)";
            if (novoMotoqueiro.Extra == false && novoMotoqueiro.Nome.EndsWith(" (Extra)"))
                novoMotoqueiro.Nome = novoMotoqueiro.Nome.Replace(" (Extra)", "");

            novoMotoqueiro.Vale = motoqueiroEditado.Vale;
            return _db.UpdateMotoqueiro(idMotoqueiroEditado, novoMotoqueiro);
        }
        public List<Motoqueiro> ListarMotoqueiros()
        {
            return _db.GetAllMotoqueiros();
        }

        public List<Motoqueiro> BuscarMotoqueiro(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do motoqueiro não pode ser vazio.", nameof(nome));
            return _db.SearchMotoqueiro(nome);
        }
        public bool DeletarMotoqueiro(int idMotoqueiro)
        {
            return _db.RemoveMotoqueiro(idMotoqueiro);
        }
        public Motoqueiro BuscarMotoqueiroId(int idMotoqueiro)
        {
            var motoqueiro = _db.GetMotoqueiroById(idMotoqueiro);
            if (motoqueiro == null)
                throw new MotoqueiroNaoEncontradoException();
            return motoqueiro;
        }

        // =========================
        // VALES
        // =========================
        public decimal ObterValeMotoqueiro(int idMotoqueiro)
        {
            return _db.GetVale(idMotoqueiro);
        }
        public void AdicionarValeMotoqueiro(int idMotoqueiro, decimal valor)
        {
            if (valor < 0)
                throw new ValeValorNegativoException();
            _db.AddVale(idMotoqueiro, valor);
        }
        public void RemoverValeMotoqueiro(int idMotoqueiro, decimal valor)
        {
            if (valor < 0)
                throw new ValeValorNegativoException();
            if (valor > _db.GetVale(idMotoqueiro))
                throw new ValorDescontadoMaiorQueValeException();
            _db.RemoveVale(idMotoqueiro, valor);
        }

        public void SetValeMotoqueiro(int idMotoqueiro, decimal valor)
        {
            if (valor < 0)
                throw new ValeValorNegativoException();
            _db.SetVale(idMotoqueiro, valor);
        }

        // =========================
        // ENTREGAS
        // =========================
        public int TotalEntregasDe5(int idMotoqueiro)
        {
            return _db.TotalEntregas5Motoqueiro(idMotoqueiro);
        }
        public int TotalEntregasDe7(int idMotoqueiro)
        {
            return _db.TotalEntregas7Motoqueiro(idMotoqueiro);
        }
        public int TotalEntregasDe10(int idMotoqueiro)
        {
            return _db.TotalEntregas10Motoqueiro(idMotoqueiro);
        }
        public int TotalEntregas(int idMotoqueiro)
        {
            return TotalEntregasDe5(idMotoqueiro) + TotalEntregasDe7(idMotoqueiro) + TotalEntregasDe10(idMotoqueiro);
        }
        public decimal TotalFixoGanho(int idMotoqueiro)
        {
            return _db.TotalFixoGanho(idMotoqueiro);
        }
        // =========================
        // VERIFICAÇÕES
        // =========================

        public void VerificaValorValeDescontado(int idMotoqueiro, decimal valorDescontado)
        {
            var motoqueiro = _db.GetMotoqueiroById(idMotoqueiro);

            if (motoqueiro == null)
                throw new MotoqueiroNaoEncontradoException();

            if (valorDescontado < 0)
                throw new ValeValorNegativoException();

            if (valorDescontado > motoqueiro.Vale)
                throw new ValorDescontadoMaiorQueValeException();
        }

        public string NormalizaNome(string nome)
        {
            string textoNormalizado = nome.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in textoNormalizado)
            {
                var categoria = CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            string semAcento = sb.ToString().Normalize(NormalizationForm.FormC);
            string somenteLetrasNumeros = Regex.Replace(semAcento, @"[^a-zA-Z0-9\s]", "");
            return somenteLetrasNumeros.ToUpper();
        }
    }
}
