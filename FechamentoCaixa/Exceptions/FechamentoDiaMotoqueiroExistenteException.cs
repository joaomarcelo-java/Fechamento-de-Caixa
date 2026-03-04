using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class FechamentoDiaMotoqueiroExistenteException : Exception
    {
        private const string DefaultMessage = "Já existe um fechamento de dia cadastrado para este motoqueiro.";

        public FechamentoDiaMotoqueiroExistenteException() : base(DefaultMessage)
        {
        }

        public FechamentoDiaMotoqueiroExistenteException(string? message) : base(message)
        {
        }

        public FechamentoDiaMotoqueiroExistenteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public FechamentoDiaMotoqueiroExistenteException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
