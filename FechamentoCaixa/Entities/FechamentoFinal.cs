using System;
using System.Collections.Generic;

namespace FechamentoCaixa.Entities
{
    public class FechamentoFinal
    {
        public int Id { get; set; }

        public DateOnly DataInicio { get; set; }
        public DateOnly DataFinal { get; set; }
        public string Nome => $"{DataInicio} - {DataFinal}";
        public List<FechamentoFinalItem> Itens { get; set; }
            = new List<FechamentoFinalItem>();
    }
}
