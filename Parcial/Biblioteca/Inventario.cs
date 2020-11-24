using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;


namespace Biblioteca
{
    public static class Inventario
    {
        private static Queue<Pedido> enPreparacion;
        private static Queue<Pedido> entregados;      
        static Inventario()
        {
            enPreparacion = new Queue<Pedido>();
            entregados = new Queue<Pedido>();
        }
        public static Queue<Pedido> EnPreparacion
        {
            get { return enPreparacion; }
        }
        public static Queue<Pedido> Entregados
        {
            get { return entregados; }
        }
        public static void LeerXml()
        {
            List<Pedido> pedidos = Leer();
            foreach (Pedido pedido in pedidos)
            {
                enPreparacion.Enqueue(pedido);
            }
        }
        public static bool Guardar(int id)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();
            List<Pedido> pedidos = new List<Pedido>();
            pedidos.Add(new Pedido(Pedido.EEntrega.Mesa,Pedido.ETipo.Milanesa,id));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EEntrega.Mesa, Pedido.ETipo.Milanesa,id));
            return auxPedidos.Guardar(path, pedidos);
        }
        public static List<Pedido> Leer()
        {
            List<Pedido> datos = new List<Pedido>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();
            auxPedidos.Leer(path, out datos);
            return datos;
        }
    }

}
