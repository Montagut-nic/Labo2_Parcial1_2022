namespace LesUTN
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.gpbPerfil = new System.Windows.Forms.GroupBox();
            this.lblAdvertenciaPerfil = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txbContrasenaActual = new System.Windows.Forms.TextBox();
            this.txbNuevaPassword = new System.Windows.Forms.TextBox();
            this.lblActualizarDatos = new System.Windows.Forms.Label();
            this.txbNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.gpbSecciones = new System.Windows.Forms.GroupBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gpbPerfil.SuspendLayout();
            this.gpbSecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPerfil
            // 
            this.gpbPerfil.BackColor = System.Drawing.Color.Salmon;
            this.gpbPerfil.Controls.Add(this.lblAdvertenciaPerfil);
            this.gpbPerfil.Controls.Add(this.btnActualizar);
            this.gpbPerfil.Controls.Add(this.txbContrasenaActual);
            this.gpbPerfil.Controls.Add(this.txbNuevaPassword);
            this.gpbPerfil.Controls.Add(this.lblActualizarDatos);
            this.gpbPerfil.Controls.Add(this.txbNombreNuevo);
            this.gpbPerfil.Controls.Add(this.lblSaludo);
            this.gpbPerfil.Location = new System.Drawing.Point(0, 153);
            this.gpbPerfil.Name = "gpbPerfil";
            this.gpbPerfil.Size = new System.Drawing.Size(863, 404);
            this.gpbPerfil.TabIndex = 0;
            this.gpbPerfil.TabStop = false;
            // 
            // lblAdvertenciaPerfil
            // 
            this.lblAdvertenciaPerfil.AutoSize = true;
            this.lblAdvertenciaPerfil.BackColor = System.Drawing.Color.Black;
            this.lblAdvertenciaPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdvertenciaPerfil.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertenciaPerfil.Location = new System.Drawing.Point(30, 328);
            this.lblAdvertenciaPerfil.Name = "lblAdvertenciaPerfil";
            this.lblAdvertenciaPerfil.Size = new System.Drawing.Size(0, 20);
            this.lblAdvertenciaPerfil.TabIndex = 6;
            this.lblAdvertenciaPerfil.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(251, 271);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 29);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Confirmar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txbContrasenaActual
            // 
            this.txbContrasenaActual.Location = new System.Drawing.Point(30, 221);
            this.txbContrasenaActual.Name = "txbContrasenaActual";
            this.txbContrasenaActual.PlaceholderText = "Ingrese su contrasena actual para confirmar";
            this.txbContrasenaActual.Size = new System.Drawing.Size(315, 27);
            this.txbContrasenaActual.TabIndex = 4;
            this.txbContrasenaActual.TextChanged += new System.EventHandler(this.txbContrasenaActual_TextChanged);
            // 
            // txbNuevaPassword
            // 
            this.txbNuevaPassword.Location = new System.Drawing.Point(30, 176);
            this.txbNuevaPassword.Name = "txbNuevaPassword";
            this.txbNuevaPassword.PlaceholderText = "Ingrese una nueva contrasena";
            this.txbNuevaPassword.Size = new System.Drawing.Size(315, 27);
            this.txbNuevaPassword.TabIndex = 3;
            // 
            // lblActualizarDatos
            // 
            this.lblActualizarDatos.AutoSize = true;
            this.lblActualizarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualizarDatos.Location = new System.Drawing.Point(30, 91);
            this.lblActualizarDatos.Name = "lblActualizarDatos";
            this.lblActualizarDatos.Size = new System.Drawing.Size(249, 20);
            this.lblActualizarDatos.TabIndex = 2;
            this.lblActualizarDatos.Text = "Actualizar informacion del usuario";
            // 
            // txbNombreNuevo
            // 
            this.txbNombreNuevo.Location = new System.Drawing.Point(30, 131);
            this.txbNombreNuevo.Name = "txbNombreNuevo";
            this.txbNombreNuevo.Size = new System.Drawing.Size(315, 27);
            this.txbNombreNuevo.TabIndex = 1;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(20, 20);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 46);
            this.lblSaludo.TabIndex = 0;
            // 
            // gpbSecciones
            // 
            this.gpbSecciones.BackColor = System.Drawing.Color.Brown;
            this.gpbSecciones.Controls.Add(this.btnUsuarios);
            this.gpbSecciones.Controls.Add(this.btnTickets);
            this.gpbSecciones.Controls.Add(this.btnStock);
            this.gpbSecciones.Controls.Add(this.btnBar);
            this.gpbSecciones.Controls.Add(this.btnPerfil);
            this.gpbSecciones.Location = new System.Drawing.Point(0, 0);
            this.gpbSecciones.Name = "gpbSecciones";
            this.gpbSecciones.Size = new System.Drawing.Size(1382, 147);
            this.gpbSecciones.TabIndex = 1;
            this.gpbSecciones.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::LesUTN.Properties.Resources.logoUsuarios;
            this.btnUsuarios.Location = new System.Drawing.Point(710, 30);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(100, 100);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnTickets
            // 
            this.btnTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.Image = global::LesUTN.Properties.Resources.logoFacturacion;
            this.btnTickets.Location = new System.Drawing.Point(540, 30);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(100, 100);
            this.btnTickets.TabIndex = 3;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTickets.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::LesUTN.Properties.Resources.logoStock;
            this.btnStock.Location = new System.Drawing.Point(370, 30);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(100, 100);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnBar
            // 
            this.btnBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBar.ForeColor = System.Drawing.Color.White;
            this.btnBar.Image = global::LesUTN.Properties.Resources.logoBarUTN;
            this.btnBar.Location = new System.Drawing.Point(200, 30);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(100, 100);
            this.btnBar.TabIndex = 1;
            this.btnBar.Text = "Bar";
            this.btnBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBar.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.AccessibleName = "Perfil";
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = global::LesUTN.Properties.Resources.logoPerfil;
            this.btnPerfil.Location = new System.Drawing.Point(30, 30);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(100, 100);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1363, 569);
            this.Controls.Add(this.gpbSecciones);
            this.Controls.Add(this.gpbPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Les UTN - Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.gpbPerfil.ResumeLayout(false);
            this.gpbPerfil.PerformLayout();
            this.gpbSecciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPerfil;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.GroupBox gpbSecciones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.TextBox txbNombreNuevo;
        private System.Windows.Forms.Label lblActualizarDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txbContrasenaActual;
        private System.Windows.Forms.TextBox txbNuevaPassword;
        private System.Windows.Forms.Label lblAdvertenciaPerfil;
    }
}