using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class FechamentoFinalExistenteException : Exception
    {
        private const string DefaultMessage = "Já existe um fechamento final salvo entre essas datas.";

        public FechamentoFinalExistenteException() : base(DefaultMessage)
        {
        }

        public FechamentoFinalExistenteException(string? message) : base(message)
        {
        }

        public FechamentoFinalExistenteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public FechamentoFinalExistenteException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
