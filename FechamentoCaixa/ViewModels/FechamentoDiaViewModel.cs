using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.ViewModel
{
    public class FechamentoDiaViewModel
    {
        public string Motoqueiro { get; set; }

        public int Entrega5 { get; set; }
        public int Entrega7 { get; set; }
        public int Entrega10 { get; set; }

        public decimal Descontos { get; set; }
        public decimal ValorFixo { get; set; }
        public decimal Total { get; set; }
    }
}
