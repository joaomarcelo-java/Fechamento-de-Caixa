using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class NomeVazioException : Exception
    {
        private const string DefaultMessage = "O nome não pode estar vazio.";

        public NomeVazioException() : base(DefaultMessage)
        {
        }

        public NomeVazioException(string? message) : base(message)
        {
        }

        public NomeVazioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public NomeVazioException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
