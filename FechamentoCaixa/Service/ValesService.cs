using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Service
{
    public class ValesService
    {
        private readonly GerenciadorDatabase _db;
        private readonly MotoqueiroService _motoqueiroService;

        public ValesService(GerenciadorDatabase db)
        {
            _db = db;
            _motoqueiroService = new MotoqueiroService(_db);
        }

        public Vales GetValeById(int idVale)
        {
            return _db.GetValeById(idVale);
        }
        public List<Vales> GetValesAtivosMotoqueiro(int idMotoqueiro)
        {
            _motoqueiroService.BuscarMotoqueiroId(idMotoqueiro);

            List<Vales> vales = _db.GetValesAtivos(idMotoqueiro);
            if (vales.Count == 0)
                throw new MotoqueiroNaoPossuiVale();
            return vales;
        }

        public List<Vales> GetAllValesMotoqueiro(int idMotoqueiro)
        {
            _motoqueiroService.BuscarMotoqueiroId(idMotoqueiro);
            return _db.GetAllVales(idMotoqueiro);
        }

        public void AddValeMotoqueiro(int idMotoqueiro, Vales vale)
        {
            _motoqueiroService.BuscarMotoqueiroId(idMotoqueiro);

            if (vale.Valor < 0)
                throw new ValeValorNegativoException();
            vale.Descricao = $"[Vale feito em {DateOnly.FromDateTime(DateTime.Now)}] - [Valor Original: {vale.Valor}]\r\n"+vale.Descricao;
            vale.Valido = true;
            _db.AddVale(idMotoqueiro, vale);
        }
        public decimal GetSaldoTotalValesMotoqueiro(int idMotoqueiro)
        {
            _motoqueiroService.BuscarMotoqueiroId(idMotoqueiro);

            var saldo = _db.GetSaldoValesMotoqueiro(idMotoqueiro);
            return saldo;
        }

        public void RemoveValeMotoqueiro(int idMotoqueiro, decimal valorDescontado)
        {
            _motoqueiroService.BuscarMotoqueiroId(idMotoqueiro);

            if (valorDescontado <= 0)
                throw new ValorDescontoNegativoException();

            List<Vales> valesAtivosMotoqueiro = _db.GetValesAtivos(idMotoqueiro)
                .OrderBy(v => v.Valor)
                .ToList();

            decimal valorTotalVales = valesAtivosMotoqueiro.Sum(v => v.Valor);

            if (valorTotalVales == 0 || valorDescontado > valorTotalVales)
                throw new ValorDescontadoMaiorQueValeException();

            foreach (var vale in valesAtivosMotoqueiro)
            {
                if (valorDescontado == 0)
                    break;

                if (valorDescontado >= vale.Valor)
                {
                    _db.RemoveVale(vale.Id);
                    valorDescontado -= vale.Valor;
                }
                else
                {
                    decimal restante = vale.Valor - valorDescontado;
                    string addDesc = $"[{DateOnly.FromDateTime(DateTime.Now)} - Valor Descontado: {valorDescontado:C}]";
                    _db.UpdateVale(vale.Id, restante, addDesc);
                    valorDescontado = 0;
                }
            }
        }
    }
}
