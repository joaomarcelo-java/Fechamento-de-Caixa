using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    public class DataInicioMaiorException : Exception
    {
        private const string DefaultMessage = "A data de inicio precisa ser menor do que a data final selecionada.";

        public DataInicioMaiorException() : base(DefaultMessage)
        {
        }

        public DataInicioMaiorException(string? message) : base(message)
        {
        }

        public DataInicioMaiorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public DataInicioMaiorException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
