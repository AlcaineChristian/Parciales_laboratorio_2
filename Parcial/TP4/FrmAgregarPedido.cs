using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Excepciones;

namespace Formularios
{
    public partial class FrmAgregarProducto : Form
    {
        Pedido auxPedido;
        int id = 0;
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            this.CmbTipo.DataSource = Enum.GetValues(typeof(Pedido.ETipo));
            this.CmbEntrega.DataSource = Enum.GetValues(typeof(Pedido.EEntrega));

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            /*SQL sql = new SQL();
            Pedido.EEntrega entrega = Pedido.EEntrega.Delivery;
            Pedido.ETipo tipo = Pedido.ETipo.Pizza;

            switch(CmbEntrega.Text)
            {
                case "Delivery":
                    entrega = Pedido.EEntrega.Delivery;
                    break;
                case "Mesa":
                    entrega = Pedido.EEntrega.Mesa;
                    break;
                case "ParaLlevar":
                    entrega = Pedido.EEntrega.ParaLlevar;
                    break;

            }
            switch (CmbTipo.Text)
            {
                case "Pizza":
                    tipo = Pedido.ETipo.Pizza;
                    break;
                case "Hamburguesa":
                    tipo = Pedido.ETipo.Hamburguesa;
                    break;
                case "Milanesa":
                    tipo = Pedido.ETipo.Milanesa;
                    break;

            }
            Pedido pedido = new Pedido(entrega, tipo, id );
            sql.InstertarProducto(pedido);
            this.Close();*/


            if (CmbEntrega.Text != "Delivery")
            {
                auxPedido = new Pedido((Pedido.EEntrega)this.CmbEntrega.SelectedItem, (Pedido.ETipo)this.CmbTipo.SelectedItem);
                Inventario.EnPreparacion.Enqueue(auxPedido);
                MessageBox.Show("Cargado con exito");
            }
            else
            {
                auxPedido = new Pedido((Pedido.EEntrega)this.CmbEntrega.SelectedItem, (Pedido.ETipo)this.CmbTipo.SelectedItem);
                Inventario.EnPreparacion.Enqueue(auxPedido);
                MessageBox.Show("Cargado con exito y ticket impreso");
            }

            

        }


    }
}
