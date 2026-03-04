using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class ValorDescontoNegativoException : Exception
    {
        private const string DefaultMessage = "O valor do desconto não pode ser negativo.";

        public ValorDescontoNegativoException() : base(DefaultMessage)
        {
        }

        public ValorDescontoNegativoException(string? message) : base(message)
        {
        }

        public ValorDescontoNegativoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public ValorDescontoNegativoException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
