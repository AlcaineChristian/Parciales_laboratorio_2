namespace Formularios

{
    partial class FrmVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.DgvListaVentas = new System.Windows.Forms.DataGridView();
            this.LblPedidos = new System.Windows.Forms.Label();
            this.LblEntregados = new System.Windows.Forms.Label();
            this.BtnAgregarPedido = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Location = new System.Drawing.Point(12, 77);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.Size = new System.Drawing.Size(367, 237);
            this.DgvListaProductos.TabIndex = 0;
            // 
            // DgvListaVentas
            // 
            this.DgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVentas.Location = new System.Drawing.Point(421, 77);
            this.DgvListaVentas.Name = "DgvListaVentas";
            this.DgvListaVentas.Size = new System.Drawing.Size(367, 237);
            this.DgvListaVentas.TabIndex = 1;
            // 
            // LblPedidos
            // 
            this.LblPedidos.AutoSize = true;
            this.LblPedidos.Location = new System.Drawing.Point(12, 31);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Size = new System.Drawing.Size(45, 13);
            this.LblPedidos.TabIndex = 2;
            this.LblPedidos.Text = "Pedidos";
            // 
            // LblEntregados
            // 
            this.LblEntregados.AutoSize = true;
            this.LblEntregados.Location = new System.Drawing.Point(418, 31);
            this.LblEntregados.Name = "LblEntregados";
            this.LblEntregados.Size = new System.Drawing.Size(61, 13);
            this.LblEntregados.TabIndex = 3;
            this.LblEntregados.Text = "Entregados";
            
            // 
            // BtnAgregarPedido
            // 
            this.BtnAgregarPedido.Location = new System.Drawing.Point(12, 372);
            this.BtnAgregarPedido.Name = "BtnAgregarPedido";
            this.BtnAgregarPedido.Size = new System.Drawing.Size(134, 23);
            this.BtnAgregarPedido.TabIndex = 4;
            this.BtnAgregarPedido.Text = "Agregar Pedido";
            this.BtnAgregarPedido.UseVisualStyleBackColor = true;
            this.BtnAgregarPedido.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(421, 372);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(134, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarPedido);
            this.Controls.Add(this.LblEntregados);
            this.Controls.Add(this.LblPedidos);
            this.Controls.Add(this.DgvListaVentas);
            this.Controls.Add(this.DgvListaProductos);
            this.Name = "FrmVenta";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaProductos;
        private System.Windows.Forms.DataGridView DgvListaVentas;
        private System.Windows.Forms.Label LblPedidos;
        private System.Windows.Forms.Label LblEntregados;
        private System.Windows.Forms.Button BtnAgregarPedido;
        private System.Windows.Forms.Button BtnSalir;
    }
}

