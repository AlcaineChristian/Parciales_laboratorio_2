﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using System.Threading;
using Excepciones;

namespace Formularios
{
    public delegate bool DelegadoDelivery(Pedido pedido);
    public partial class FrmVenta : Form
    {
        Thread actualizarPantalla;
        public event DelegadoDelivery delivery;
        Random random;
        public FrmVenta()
        {
            InitializeComponent();
            actualizarPantalla = new Thread(this.ActualizarPedidos);
            random = new Random();
            SQL sql = new SQL();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            //Inventario.Guardar();
            try
            {

                Inventario.Hardcodeo();

                ActualizarEnPreparacion();
                ActualizarEntregados();

                delivery += Pedido.PrintTicket;

                if (!actualizarPantalla.IsAlive)
                {
                    actualizarPantalla.Start();

                }
                else
                {
                    actualizarPantalla.Abort();
                    actualizarPantalla.Start();
                }


            }
            catch (ExcepcionesArchivos exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.InnerException.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregar = new FrmAgregarProducto();
            frmAgregar.Show();
        }

        private void LblVenta_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarPedidos()
        {

            while (true)
            {
                ActualizarEnPreparacion();
                Thread.Sleep(4000);

                if (Inventario.EnPreparacion.Count > 0)
                {
                    Pedido p1;
                    p1 = Inventario.EnPreparacion.Dequeue();
                    SQL.InstertarProducto(p1);
                    Inventario.Entregados.Enqueue(p1);

                    if (p1.Entrega == Pedido.EEntrega.Delivery)
                        delivery.Invoke(p1);

                    ActualizarEnPreparacion();
                    ActualizarEntregados();

                    Thread.Sleep(random.Next(2000, 4000));
                }
            }
        }
        private void ActualizarEnPreparacion()
        {
            if (this.DgvListaProductos.InvokeRequired)
            {
                this.DgvListaProductos.BeginInvoke((MethodInvoker)delegate ()
                {
                    ActualizarDatagridviewEnPreparacion();

                });
            }
            else
            {
                ActualizarDatagridviewEnPreparacion();
            }
        }
        private void ActualizarEntregados()
        {
            if (this.DgvListaVentas.InvokeRequired)
            {
                this.DgvListaVentas.BeginInvoke((MethodInvoker)delegate ()
                {
                    ActualizarDatagridviewEntregados();
                });
            }
            else
            {
                ActualizarDatagridviewEntregados();
            }
        }

        /// <summary>
        /// Actualiza datagridview
        /// </summary>
        private void ActualizarDatagridviewEnPreparacion()
        {
            this.DgvListaProductos.DataSource = null;
            this.DgvListaProductos.DataSource = Inventario.EnPreparacion.ToArray();
        }

        /// <summary>
        /// Actualiza datagridview
        /// </summary>
        private void ActualizarDatagridviewEntregados()
        {
            this.DgvListaVentas.DataSource = null;
            this.DgvListaVentas.DataSource = Inventario.Entregados.ToArray();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            actualizarPantalla.Abort();
            this.Close();
        }
    }
}