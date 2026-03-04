using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class DataFinalMenorException : Exception
    {
        private const string DefaultMessage = "A data final selecionada, precisa ser maior do que a data de inicio.";

        public DataFinalMenorException() : base(DefaultMessage)
        {
        }

        public DataFinalMenorException(string? message) : base(message)
        {
        }

        public DataFinalMenorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public DataFinalMenorException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
