using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class ResumoVazioException : Exception
    {
        private const string DefaultMessage = "Não foram encontrados registros de fechamentos no período indicado.";

        public ResumoVazioException() : base(DefaultMessage)
        {
        }

        public ResumoVazioException(string? message) : base(message)
        {
        }

        public ResumoVazioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public ResumoVazioException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
