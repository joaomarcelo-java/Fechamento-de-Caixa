using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class NenhumMotoqueiroSelecionadoException : Exception
    {
        private const string DefaultMessage = "Nenhum motoqueiro selecionado.";

        public NenhumMotoqueiroSelecionadoException() : base(DefaultMessage)
        {
        }

        public NenhumMotoqueiroSelecionadoException(string? message) : base(message)
        {
        }

        public NenhumMotoqueiroSelecionadoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public NenhumMotoqueiroSelecionadoException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}