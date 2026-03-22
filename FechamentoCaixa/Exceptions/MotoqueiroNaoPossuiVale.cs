using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class MotoqueiroNaoPossuiVale : Exception
    {
        private const string DefaultMessage = "O motoqueiro não possui vale.";

        public MotoqueiroNaoPossuiVale() : base(DefaultMessage)
        {
        }

        public MotoqueiroNaoPossuiVale(string? message) : base(message)
        {
        }

        public MotoqueiroNaoPossuiVale(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public MotoqueiroNaoPossuiVale(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
