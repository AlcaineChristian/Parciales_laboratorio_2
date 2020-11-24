using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionesArchivos : Exception
    {
        public ExcepcionesArchivos(string mensaje) : base(mensaje)
        {

        }

        public ExcepcionesArchivos(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
