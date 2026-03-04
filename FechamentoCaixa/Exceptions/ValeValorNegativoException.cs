using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class ValeValorNegativoException : Exception
    {
        private const string DefaultMessage = "O valor do vale não pode ser negativo.";

        public ValeValorNegativoException() : base(DefaultMessage)
        {
        }

        public ValeValorNegativoException(string? message) : base(message)
        {
        }

        public ValeValorNegativoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public ValeValorNegativoException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
