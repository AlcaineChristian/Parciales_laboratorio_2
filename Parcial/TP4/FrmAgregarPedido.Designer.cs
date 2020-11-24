namespace Formularios
{
    partial class FrmAgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTipo = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblIngreso = new System.Windows.Forms.Label();
            this.CmbEntrega = new System.Windows.Forms.ComboBox();
            this.LblEntrega = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(73, 115);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(135, 248);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(173, 115);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 5;
            // 
            // LblIngreso
            // 
            this.LblIngreso.AutoSize = true;
            this.LblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngreso.Location = new System.Drawing.Point(69, 34);
            this.LblIngreso.Name = "LblIngreso";
            this.LblIngreso.Size = new System.Drawing.Size(208, 20);
            this.LblIngreso.TabIndex = 9;
            this.LblIngreso.Text = "Ingrese datos del pedido";
            // 
            // CmbEntrega
            // 
            this.CmbEntrega.FormattingEnabled = true;
            this.CmbEntrega.Location = new System.Drawing.Point(173, 161);
            this.CmbEntrega.Name = "CmbEntrega";
            this.CmbEntrega.Size = new System.Drawing.Size(121, 21);
            this.CmbEntrega.TabIndex = 12;
            // 
            // LblEntrega
            // 
            this.LblEntrega.AutoSize = true;
            this.LblEntrega.Location = new System.Drawing.Point(73, 164);
            this.LblEntrega.Name = "LblEntrega";
            this.LblEntrega.Size = new System.Drawing.Size(44, 13);
            this.LblEntrega.TabIndex = 13;
            this.LblEntrega.Text = "Entrega";
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 304);
            this.Controls.Add(this.LblEntrega);
            this.Controls.Add(this.CmbEntrega);
            this.Controls.Add(this.LblIngreso);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTipo);
            this.Name = "FrmAgregarProducto";
            this.Text = "Agregar producto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblIngreso;
        private System.Windows.Forms.ComboBox CmbEntrega;
        private System.Windows.Forms.Label LblEntrega;
    }
}