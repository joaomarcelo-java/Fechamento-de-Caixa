using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FechamentoFinalItem
{
    public int Id { get; set; }

    public int FechamentoFinalId { get; set; }
    public int MotoqueiroId { get; set; }

    public int Taxa5 { get; set; }
    public int Taxa7 { get; set; }
    public int Taxa10 { get; set; }

    public decimal ValeDescontado { get; set; } 
    public decimal DescontoExtra { get; set; } 
    public decimal TotalFixo { get; set; } 

    public decimal TotalBruto { get; set; } 
    public decimal TotalLiquido { get; set; } 
}
