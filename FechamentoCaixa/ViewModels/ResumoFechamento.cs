using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.ViewModels
{
    public class ResumoFechamento
    {
        public int MotoqueiroId { get; set; }
        public string Motoqueiro { get; set; }

        public int Taxa5 { get; set; }
        public int Taxa7 { get; set; }
        public int Taxa10 { get; set; }

        public decimal TotalFixo { get; set; } //Total dos valores fixos recebidos por dia
        public decimal TotalGeral { get; set; } //Total geral calculado com base nas taxas e valores fixos, sem considerar os descontos. É a soma do total fixo e o valor calculado pelas taxas (Taxa5, Taxa7, Taxa10) aplicadas sobre as entregas realizadas pelo motoqueiro.
    }

}
