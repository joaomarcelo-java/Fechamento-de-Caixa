using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class ValorDescontadoMaiorQueValeException : Exception
    {
        private const string DefaultMessage = "O valor digitado é maior do que o vale atual do motoqueiro.";

        public ValorDescontadoMaiorQueValeException() : base(DefaultMessage)
        {
        }

        public ValorDescontadoMaiorQueValeException(string? message) : base(message)
        {
        }

        public ValorDescontadoMaiorQueValeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public ValorDescontadoMaiorQueValeException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}