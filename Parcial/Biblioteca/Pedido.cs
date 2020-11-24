using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;


namespace Biblioteca
{
    
    public class Pedido
    {
        ETipo tipo;
        EEntrega entrega;
        int nroPedido=0;
        public enum EEntrega
        {
            Delivery,
            Mesa,
            ParaLlevar
        }
        public enum ETipo
        {
            Pizza,
            Hamburguesa,
            Milanesa
        }
        public Pedido()
        {

        }
        public Pedido(EEntrega entrega, ETipo tipo,int id)
        {
            this.tipo = tipo;
            this.entrega = entrega;
            this.nroPedido = id;
        }
        
        public int NroPedido
        {
            get
            {
                return this.nroPedido;
            }
        }
        public ETipo Tipo
        {
            get 
            { 
                return this.tipo;
            }
        }
        public EEntrega Entrega
        {
            get
            {
                return this.entrega;
            }
        }
        public static bool PrintTicket(Pedido pedido)
        {
            bool retorno = false;
            string path;

            if (pedido != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, pedido.nroPedido.ToString());

                Texto texto = new Texto();

                texto.Guardar(path, pedido.ToString());
                retorno = true;
            }

            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Tipo: {this.tipo.ToString()}");
            sb.AppendLine($"Entrega: {this.entrega.ToString()}");
            
            return sb.ToString();
        }
    }
}
