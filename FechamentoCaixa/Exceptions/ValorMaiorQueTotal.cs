using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class ValorMaiorQueTotalException : Exception
    {
        private const string DefaultMessage = "Os valores descontados são maiores do que a quantia disponível.";

        public ValorMaiorQueTotalException() : base(DefaultMessage)
        {
        }

        public ValorMaiorQueTotalException(string? message) : base(message)
        {
        }

        public ValorMaiorQueTotalException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public ValorMaiorQueTotalException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
