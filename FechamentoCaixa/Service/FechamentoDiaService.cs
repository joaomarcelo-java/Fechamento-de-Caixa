using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Exceptions;
using FechamentoCaixa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Service
{
    public class FechamentoDiaService
    {
        private readonly GerenciadorDatabase _db;
        public FechamentoDiaService(GerenciadorDatabase db)
        {
            _db = db;
        }
        public void FecharDiaMotoqueiro(FechamentoDia fechamento)
        {
            if (_db.IsDateInsideFechamentoFinal(fechamento.Data))
                throw new FechamentoFinalExistenteException();
            if (_db.ExistsFechamentoDia(fechamento.MotoqueiroId, fechamento.Data))
                throw new FechamentoDiaMotoqueiroExistenteException();
            if(fechamento.Entrega5 < 0 || fechamento.Entrega7 < 0 || fechamento.Entrega10 < 0)
                throw new ArgumentException("A quantidade de entregas não pode ser negativa.");
            if(fechamento.ValorFixo < 0)
                throw new ArgumentException("O valor fixo não pode ser negativo.");
            if(fechamento.Desconto < 0)
                throw new ArgumentException("O desconto não pode ser negativo.");
            if (fechamento.Desconto > (5 * fechamento.Entrega5) + (7 * fechamento.Entrega7) + (10 * fechamento.Entrega10) + fechamento.ValorFixo)
                throw new ArgumentException("O desconto não pode ser maior que o valor do dia.");


            _db.AddFechamentoDia(fechamento);
        }
        public void EditarFechamentoDiaMotoqueiro(FechamentoDia fechamento, DateOnly data)
        {
            if (!_db.ExistsFechamentoDia(fechamento.MotoqueiroId, data))
                throw new FechamentoDiaMotoqueiroInexistenteException();
            if(_db.IsDateInsideFechamentoFinal(data))
                throw new FechamentoFinalExistenteException();
            if (fechamento.Entrega5 < 0 || fechamento.Entrega7 < 0 || fechamento.Entrega10 < 0)
                throw new ArgumentException("A quantidade de entregas não pode ser negativa.");
            if (fechamento.ValorFixo < 0)
                throw new ArgumentException("O valor fixo não pode ser negativo.");
            if (fechamento.Desconto < 0)
                throw new ArgumentException("O desconto não pode ser negativo.");
            if (fechamento.Desconto > (5 * fechamento.Entrega5) + (7 * fechamento.Entrega7) + (10 * fechamento.Entrega10) + fechamento.ValorFixo)
                throw new ArgumentException("O desconto não pode ser maior que o valor do dia.");



            _db.UpdateFechamentoDia(fechamento, data);
        }
        public void DeletarFechamentoDiaMotoqueiro(int motoqueiroId, DateOnly data)
        {
            if (!_db.ExistsFechamentoDia(motoqueiroId, data))
                throw new FechamentoDiaMotoqueiroInexistenteException();
            if (_db.IsDateInsideFechamentoFinal(data))
                throw new FechamentoFinalExistenteException();
           
            _db.RemoveFechamentoDia(motoqueiroId, data);

        }
        public List<FechamentoDiaViewModel> ObterFechamentosDoDiaModel(DateOnly data)
        {
            return _db.GetFechamentosByDate(data);
        }
        public FechamentoDia ObterFechamentoDiaMotoqueiro(int motoqueiroId, DateOnly data)
        {
            return _db.GetFechamentoDia(motoqueiroId, data);
        }
    }
}
