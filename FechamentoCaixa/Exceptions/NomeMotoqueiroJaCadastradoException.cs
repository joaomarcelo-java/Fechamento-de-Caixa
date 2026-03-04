using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Exceptions
{
    internal class NomeMotoqueiroJaCadastradoException : Exception
    {
        private const string DefaultMessage = "Já existe um motoqueiro cadastrado com esse nome.";

        public NomeMotoqueiroJaCadastradoException() : base(DefaultMessage)
        {
        }

        public NomeMotoqueiroJaCadastradoException(string? message) : base(message)
        {
        }

        public NomeMotoqueiroJaCadastradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public NomeMotoqueiroJaCadastradoException(Exception? innerException) : base(DefaultMessage, innerException)
        {
        }
    }
}
