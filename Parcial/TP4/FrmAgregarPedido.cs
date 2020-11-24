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
            if (CmbEntrega.Text != "Delivery")
            {
                auxPedido = new Pedido((Pedido.EEntrega)this.CmbEntrega.SelectedItem, (Pedido.ETipo)this.CmbTipo.SelectedItem, Program.id = Program.id + 1);
                Inventario.EnPreparacion.Enqueue(auxPedido);
                MessageBox.Show("Cargado con exito");
            }
            else
            {
                auxPedido = new Pedido((Pedido.EEntrega)this.CmbEntrega.SelectedItem, (Pedido.ETipo)this.CmbTipo.SelectedItem, Program.id = Program.id + 1);
                Inventario.EnPreparacion.Enqueue(auxPedido);
                MessageBox.Show("Cargado con exito y ticket impreso");
            }
        }
    }
}
