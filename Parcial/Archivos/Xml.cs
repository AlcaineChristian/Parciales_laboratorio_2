using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivos
{
    public class Xml<T> : Archivos<T>
    {
        
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                if (archivo != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        ser.Serialize(writer, datos);

                        return true;
                        
                    }
                }
            }
            catch (Exception e)
            {

                throw new ExcepcionesArchivos("No se guardo el archivo", e);
            }

            return false;
        }

        
        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);

            try
            {
                if (File.Exists(archivo))
                {
                    using (XmlTextReader reader = new XmlTextReader(archivo))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        datos = (T)ser.Deserialize(reader);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ExcepcionesArchivos("No se leyo el archivo", e);
            }

            return false;
        }
    }
}
