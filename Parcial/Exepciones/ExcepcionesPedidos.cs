using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionesPedidos : Exception
    {
        public ExcepcionesPedidos(string message) : base(message)
        {

        }
    }
}
