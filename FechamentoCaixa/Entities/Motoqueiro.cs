using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Entities
{
    public class Motoqueiro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Vale { get; set; } 
        public bool Extra { get; set; } 
        public Motoqueiro() { }
        public Motoqueiro(string nome, decimal vale, bool extra)
        {
            Nome = nome;
            Vale = vale;
            Extra = extra;
        }
        public Motoqueiro(string nome, bool extra)
        {
            Nome = nome;
            Extra = extra;
        }
    }
}
