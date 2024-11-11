namespace Proyecto_Final
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.lblNombreProdct = new System.Windows.Forms.Label();
            this.lblCantidadVend = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFechatransc = new System.Windows.Forms.Label();
            this.lbllCliente = new System.Windows.Forms.Label();
            this.btRegistrarTransc = new System.Windows.Forms.Button();
            this.btHistorialTransc = new System.Windows.Forms.Button();
            this.tbNombreProdct = new System.Windows.Forms.TextBox();
            this.tbCantidadVend = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbFechatransc = new System.Windows.Forms.TextBox();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.gpbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(379, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de ingresos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.btHistorialTransc);
            this.gpbRegistro.Controls.Add(this.tbDestino);
            this.gpbRegistro.Controls.Add(this.btRegistrarTransc);
            this.gpbRegistro.Controls.Add(this.tbFechatransc);
            this.gpbRegistro.Controls.Add(this.tbPrecio);
            this.gpbRegistro.Controls.Add(this.tbCantidadVend);
            this.gpbRegistro.Controls.Add(this.tbNombreProdct);
            this.gpbRegistro.Controls.Add(this.lbllCliente);
            this.gpbRegistro.Controls.Add(this.lblFechatransc);
            this.gpbRegistro.Controls.Add(this.lblPrecio);
            this.gpbRegistro.Controls.Add(this.lblCantidadVend);
            this.gpbRegistro.Controls.Add(this.lblNombreProdct);
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(95, 113);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Size = new System.Drawing.Size(819, 292);
            this.gpbRegistro.TabIndex = 1;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Registro de transacciones ";
            // 
            // lblNombreProdct
            // 
            this.lblNombreProdct.AutoSize = true;
            this.lblNombreProdct.Location = new System.Drawing.Point(63, 52);
            this.lblNombreProdct.Name = "lblNombreProdct";
            this.lblNombreProdct.Size = new System.Drawing.Size(196, 16);
            this.lblNombreProdct.TabIndex = 0;
            this.lblNombreProdct.Text = "Nombre del Producto/Reactivo:";
            // 
            // lblCantidadVend
            // 
            this.lblCantidadVend.AutoSize = true;
            this.lblCantidadVend.Location = new System.Drawing.Point(63, 106);
            this.lblCantidadVend.Name = "lblCantidadVend";
            this.lblCantidadVend.Size = new System.Drawing.Size(186, 16);
            this.lblCantidadVend.TabIndex = 1;
            this.lblCantidadVend.Text = "Cantidad consumida/vendida:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(63, 147);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblFechatransc
            // 
            this.lblFechatransc.AutoSize = true;
            this.lblFechatransc.Location = new System.Drawing.Point(63, 184);
            this.lblFechatransc.Name = "lblFechatransc";
            this.lblFechatransc.Size = new System.Drawing.Size(139, 16);
            this.lblFechatransc.TabIndex = 3;
            this.lblFechatransc.Text = "Fecha de transaccion:";
            // 
            // lbllCliente
            // 
            this.lbllCliente.AutoSize = true;
            this.lbllCliente.Location = new System.Drawing.Point(63, 231);
            this.lbllCliente.Name = "lbllCliente";
            this.lbllCliente.Size = new System.Drawing.Size(109, 16);
            this.lbllCliente.TabIndex = 4;
            this.lbllCliente.Text = "Cliente o destino:";
            // 
            // btRegistrarTransc
            // 
            this.btRegistrarTransc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btRegistrarTransc.Location = new System.Drawing.Point(631, 52);
            this.btRegistrarTransc.Name = "btRegistrarTransc";
            this.btRegistrarTransc.Size = new System.Drawing.Size(101, 54);
            this.btRegistrarTransc.TabIndex = 2;
            this.btRegistrarTransc.Text = "Registrar Transaccion";
            this.btRegistrarTransc.UseVisualStyleBackColor = false;
            // 
            // btHistorialTransc
            // 
            this.btHistorialTransc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btHistorialTransc.Location = new System.Drawing.Point(631, 165);
            this.btHistorialTransc.Name = "btHistorialTransc";
            this.btHistorialTransc.Size = new System.Drawing.Size(101, 54);
            this.btHistorialTransc.TabIndex = 3;
            this.btHistorialTransc.Text = "Historial de transacciones";
            this.btHistorialTransc.UseVisualStyleBackColor = false;
            // 
            // tbNombreProdct
            // 
            this.tbNombreProdct.Location = new System.Drawing.Point(289, 52);
            this.tbNombreProdct.MaxLength = 100;
            this.tbNombreProdct.Name = "tbNombreProdct";
            this.tbNombreProdct.Size = new System.Drawing.Size(219, 22);
            this.tbNombreProdct.TabIndex = 5;
            // 
            // tbCantidadVend
            // 
            this.tbCantidadVend.Location = new System.Drawing.Point(289, 100);
            this.tbCantidadVend.Name = "tbCantidadVend";
            this.tbCantidadVend.Size = new System.Drawing.Size(219, 22);
            this.tbCantidadVend.TabIndex = 6;
            this.tbCantidadVend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(289, 141);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(219, 22);
            this.tbPrecio.TabIndex = 7;
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFechatransc
            // 
            this.tbFechatransc.Location = new System.Drawing.Point(289, 181);
            this.tbFechatransc.Name = "tbFechatransc";
            this.tbFechatransc.Size = new System.Drawing.Size(219, 22);
            this.tbFechatransc.TabIndex = 8;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(289, 225);
            this.tbDestino.MaxLength = 100;
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(219, 22);
            this.tbDestino.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 536);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Calculo de ingresos";
            this.gpbRegistro.ResumeLayout(false);
            this.gpbRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.Label lbllCliente;
        private System.Windows.Forms.Label lblFechatransc;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidadVend;
        private System.Windows.Forms.Label lblNombreProdct;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.TextBox tbFechatransc;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCantidadVend;
        private System.Windows.Forms.TextBox tbNombreProdct;
        private System.Windows.Forms.Button btRegistrarTransc;
        private System.Windows.Forms.Button btHistorialTransc;
    }
}

