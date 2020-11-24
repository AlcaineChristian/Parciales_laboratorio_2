using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Ventas
    {
        double precioTotal;
        int idVenta;

        public Ventas(double precioTotal,int idVenta)
        {
            this.precioTotal = precioTotal;
            this.idVenta = idVenta;
        }
        public double PrecioTotal
        {
            get
            {
                return this.precioTotal;
            }
        }
        public int IdVenta
        {
            get
            {
                return this.idVenta;
            }
        }
    }
}
