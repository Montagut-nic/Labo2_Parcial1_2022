namespace LesUTN
{
    partial class MenuPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPedidos));
            this.rtbOrden = new System.Windows.Forms.RichTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.ltbProductos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gbpMetodoDePago = new System.Windows.Forms.GroupBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtMercadopago = new System.Windows.Forms.RadioButton();
            this.rbtDebito = new System.Windows.Forms.RadioButton();
            this.rbtCredito = new System.Windows.Forms.RadioButton();
            this.cbxEstacionamiento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gbpMetodoDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbOrden
            // 
            this.rtbOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOrden.Location = new System.Drawing.Point(6, 48);
            this.rtbOrden.Name = "rtbOrden";
            this.rtbOrden.ReadOnly = true;
            this.rtbOrden.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOrden.Size = new System.Drawing.Size(397, 215);
            this.rtbOrden.TabIndex = 0;
            this.rtbOrden.Text = "";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(177, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 28);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: $";
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.Location = new System.Drawing.Point(618, 16);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarOrden.TabIndex = 2;
            this.btnCancelarOrden.Text = "Cancelar Orden";
            this.btnCancelarOrden.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(20, 454);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(94, 29);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroOrden.Location = new System.Drawing.Point(20, 16);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(108, 20);
            this.lblNroOrden.TabIndex = 5;
            this.lblNroOrden.Text = "Nro de Orden:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(684, 290);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(59, 27);
            this.nudCantidad.TabIndex = 6;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ltbProductos
            // 
            this.ltbProductos.FormattingEnabled = true;
            this.ltbProductos.ItemHeight = 20;
            this.ltbProductos.Location = new System.Drawing.Point(409, 79);
            this.ltbProductos.Name = "ltbProductos";
            this.ltbProductos.Size = new System.Drawing.Size(336, 184);
            this.ltbProductos.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(430, 290);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(561, 290);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 29);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // gbpMetodoDePago
            // 
            this.gbpMetodoDePago.BackColor = System.Drawing.SystemColors.Control;
            this.gbpMetodoDePago.Controls.Add(this.rbtCredito);
            this.gbpMetodoDePago.Controls.Add(this.rbtDebito);
            this.gbpMetodoDePago.Controls.Add(this.rbtMercadopago);
            this.gbpMetodoDePago.Controls.Add(this.rbtEfectivo);
            this.gbpMetodoDePago.Location = new System.Drawing.Point(9, 285);
            this.gbpMetodoDePago.Name = "gbpMetodoDePago";
            this.gbpMetodoDePago.Size = new System.Drawing.Size(281, 134);
            this.gbpMetodoDePago.TabIndex = 10;
            this.gbpMetodoDePago.TabStop = false;
            this.gbpMetodoDePago.Text = "Metodo de Pago";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(11, 36);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(83, 24);
            this.rbtEfectivo.TabIndex = 0;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtMercadopago
            // 
            this.rbtMercadopago.AutoSize = true;
            this.rbtMercadopago.Location = new System.Drawing.Point(136, 36);
            this.rbtMercadopago.Name = "rbtMercadopago";
            this.rbtMercadopago.Size = new System.Drawing.Size(124, 24);
            this.rbtMercadopago.TabIndex = 1;
            this.rbtMercadopago.TabStop = true;
            this.rbtMercadopago.Text = "Mercadopago";
            this.rbtMercadopago.UseVisualStyleBackColor = true;
            // 
            // rbtDebito
            // 
            this.rbtDebito.AutoSize = true;
            this.rbtDebito.Location = new System.Drawing.Point(11, 84);
            this.rbtDebito.Name = "rbtDebito";
            this.rbtDebito.Size = new System.Drawing.Size(76, 24);
            this.rbtDebito.TabIndex = 2;
            this.rbtDebito.TabStop = true;
            this.rbtDebito.Text = "Debito";
            this.rbtDebito.UseVisualStyleBackColor = true;
            // 
            // rbtCredito
            // 
            this.rbtCredito.AutoSize = true;
            this.rbtCredito.Location = new System.Drawing.Point(136, 84);
            this.rbtCredito.Name = "rbtCredito";
            this.rbtCredito.Size = new System.Drawing.Size(79, 24);
            this.rbtCredito.TabIndex = 3;
            this.rbtCredito.TabStop = true;
            this.rbtCredito.Text = "Credito";
            this.rbtCredito.UseVisualStyleBackColor = true;
            // 
            // cbxEstacionamiento
            // 
            this.cbxEstacionamiento.AutoSize = true;
            this.cbxEstacionamiento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxEstacionamiento.Location = new System.Drawing.Point(311, 395);
            this.cbxEstacionamiento.Name = "cbxEstacionamiento";
            this.cbxEstacionamiento.Size = new System.Drawing.Size(169, 24);
            this.cbxEstacionamiento.TabIndex = 11;
            this.cbxEstacionamiento.Text = "Usa estacionamiento";
            this.cbxEstacionamiento.UseVisualStyleBackColor = false;
            // 
            // MenuPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(757, 495);
            this.Controls.Add(this.cbxEstacionamiento);
            this.Controls.Add(this.gbpMetodoDePago);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.ltbProductos);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblNroOrden);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnCancelarOrden);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rtbOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les UTN - Pedido";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gbpMetodoDePago.ResumeLayout(false);
            this.gbpMetodoDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOrden;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ListBox ltbProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox gbpMetodoDePago;
        private System.Windows.Forms.RadioButton rbtCredito;
        private System.Windows.Forms.RadioButton rbtDebito;
        private System.Windows.Forms.RadioButton rbtMercadopago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.CheckBox cbxEstacionamiento;
    }
}