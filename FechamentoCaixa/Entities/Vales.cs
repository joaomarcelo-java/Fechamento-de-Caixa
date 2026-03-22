using FechamentoCaixa.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Entities
{
    public class Vales
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int MotoqueiroId { get; set; }
        public Motoqueiro Motoqueiro { get; set; }
        public bool Valido { get; set; }
        public DateOnly Data { get; set; }

        //Para DB
        public Vales(decimal valor, string descricao, int motoqueiroId, bool valido, DateOnly data)
        {
            Valor = valor;
            Descricao = descricao;
            MotoqueiroId = motoqueiroId;
            Valido = valido;
            Data = data;
        }

        //Para uso
        public Vales(decimal valor, string descricao, DateOnly data)
        {
            Valor = valor;
            Descricao += descricao;
            Data = data;
        }

        //Para migração
        public Vales(decimal valor, int idMotoqueiro, string descricao)
        {
            Valor = valor;
            MotoqueiroId = idMotoqueiro;
            Descricao = descricao;
        }

        public Vales() { }
        public override string ToString()
        {
            return $"{Valor:C} - {Data}";
        }
    }
}
