using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Entities
{
    public class FechamentoDia
    {
        public int Id { get; set; } 
        public DateOnly Data { get; set; }
        public int Entrega5 { get; set; } 
        public int Entrega7 { get; set; }
        public int Entrega10 { get; set; } 
        public int MotoqueiroId { get; set; } 
        public Motoqueiro Motoqueiro { get; set; } 
        public decimal ValorFixo { get; set; } 
        public decimal Desconto { get; set; } 
        public decimal ValorDia => CalcularValorDia(); 

        public decimal CalcularValorDia() 
        {
            return (5 * Entrega5) + (7 * Entrega7) + (10 * Entrega10) + ValorFixo - Desconto;
        }
    }
}
