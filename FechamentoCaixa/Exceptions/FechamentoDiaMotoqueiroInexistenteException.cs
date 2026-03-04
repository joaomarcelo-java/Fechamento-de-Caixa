using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class FechamentoDiaMotoqueiroInexistenteException : Exception
    {
        private const string DefaultMessage = "Não existe fechamento deste motoqueiro nesta data.";

        public FechamentoDiaMotoqueiroInexistenteException() : base(DefaultMessage)
        {
        }

        public FechamentoDiaMotoqueiroInexistenteException(string? message) : base(message)
        {
        }

        public FechamentoDiaMotoqueiroInexistenteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public FechamentoDiaMotoqueiroInexistenteException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
