using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class MotoqueiroNaoEncontradoException : Exception
    {
        private const string DefaultMessage = "O motoqueiro a ser editado não foi encontrado.";

        public MotoqueiroNaoEncontradoException() : base(DefaultMessage)
        {
        }

        public MotoqueiroNaoEncontradoException(string? message) : base(message)
        {
        }

        public MotoqueiroNaoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public MotoqueiroNaoEncontradoException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
