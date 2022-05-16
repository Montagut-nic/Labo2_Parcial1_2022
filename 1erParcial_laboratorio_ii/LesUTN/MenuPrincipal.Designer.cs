﻿namespace LesUTN
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
            this.lblAdvertenciaPerfil = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txbContrasenaActual = new System.Windows.Forms.TextBox();
            this.txbNuevaPassword = new System.Windows.Forms.TextBox();
            this.lblActualizarDatos = new System.Windows.Forms.Label();
            this.txbNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.gpbSecciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbSecciones.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdvertenciaPerfil
            // 
            this.lblAdvertenciaPerfil.AutoSize = true;
            this.lblAdvertenciaPerfil.BackColor = System.Drawing.Color.Black;
            this.lblAdvertenciaPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdvertenciaPerfil.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertenciaPerfil.Location = new System.Drawing.Point(82, 308);
            this.lblAdvertenciaPerfil.Name = "lblAdvertenciaPerfil";
            this.lblAdvertenciaPerfil.Size = new System.Drawing.Size(0, 20);
            this.lblAdvertenciaPerfil.TabIndex = 6;
            this.lblAdvertenciaPerfil.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(432, 243);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 29);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Confirmar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txbContrasenaActual
            // 
            this.txbContrasenaActual.Location = new System.Drawing.Point(82, 244);
            this.txbContrasenaActual.Name = "txbContrasenaActual";
            this.txbContrasenaActual.PasswordChar = '*';
            this.txbContrasenaActual.PlaceholderText = "Ingrese su contrasena actual para confirmar";
            this.txbContrasenaActual.Size = new System.Drawing.Size(315, 27);
            this.txbContrasenaActual.TabIndex = 4;
            this.txbContrasenaActual.TextChanged += new System.EventHandler(this.txbContrasenaActual_TextChanged);
            // 
            // txbNuevaPassword
            // 
            this.txbNuevaPassword.Location = new System.Drawing.Point(82, 201);
            this.txbNuevaPassword.Name = "txbNuevaPassword";
            this.txbNuevaPassword.PasswordChar = '*';
            this.txbNuevaPassword.PlaceholderText = "Ingrese una nueva contrasena";
            this.txbNuevaPassword.Size = new System.Drawing.Size(315, 27);
            this.txbNuevaPassword.TabIndex = 3;
            // 
            // lblActualizarDatos
            // 
            this.lblActualizarDatos.AutoSize = true;
            this.lblActualizarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualizarDatos.Location = new System.Drawing.Point(82, 111);
            this.lblActualizarDatos.Name = "lblActualizarDatos";
            this.lblActualizarDatos.Size = new System.Drawing.Size(249, 20);
            this.lblActualizarDatos.TabIndex = 2;
            this.lblActualizarDatos.Text = "Actualizar informacion del usuario";
            // 
            // txbNombreNuevo
            // 
            this.txbNombreNuevo.Location = new System.Drawing.Point(82, 156);
            this.txbNombreNuevo.Name = "txbNombreNuevo";
            this.txbNombreNuevo.Size = new System.Drawing.Size(315, 27);
            this.txbNombreNuevo.TabIndex = 1;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(82, 26);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 46);
            this.lblSaludo.TabIndex = 0;
            // 
            // gpbSecciones
            // 
            this.gpbSecciones.BackColor = System.Drawing.Color.Brown;
            this.gpbSecciones.Controls.Add(this.btnSalir);
            this.gpbSecciones.Controls.Add(this.btnLogout);
            this.gpbSecciones.Controls.Add(this.btnUsuarios);
            this.gpbSecciones.Controls.Add(this.btnTickets);
            this.gpbSecciones.Controls.Add(this.btnStock);
            this.gpbSecciones.Controls.Add(this.btnBar);
            this.gpbSecciones.Controls.Add(this.btnPerfil);
            this.gpbSecciones.Location = new System.Drawing.Point(0, 0);
            this.gpbSecciones.Margin = new System.Windows.Forms.Padding(0);
            this.gpbSecciones.Name = "gpbSecciones";
            this.gpbSecciones.Padding = new System.Windows.Forms.Padding(0);
            this.gpbSecciones.Size = new System.Drawing.Size(1016, 144);
            this.gpbSecciones.TabIndex = 1;
            this.gpbSecciones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::LesUTN.Properties.Resources.logoSalir;
            this.btnSalir.Location = new System.Drawing.Point(940, 30);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::LesUTN.Properties.Resources.logoLogout;
            this.btnLogout.Location = new System.Drawing.Point(860, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnUsuarios.Click += new System.EventHandler(this.btnSecciones_Click);
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
            this.btnTickets.Click += new System.EventHandler(this.btnSecciones_Click);
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
            this.btnStock.Click += new System.EventHandler(this.btnSecciones_Click);
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
            this.btnBar.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AccessibleName = "Perfil";
            this.btnPerfil.Enabled = false;
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
            this.btnPerfil.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Controls.Add(this.lblSaludo);
            this.pnlPerfil.Controls.Add(this.lblAdvertenciaPerfil);
            this.pnlPerfil.Controls.Add(this.lblActualizarDatos);
            this.pnlPerfil.Controls.Add(this.btnActualizar);
            this.pnlPerfil.Controls.Add(this.txbNombreNuevo);
            this.pnlPerfil.Controls.Add(this.txbContrasenaActual);
            this.pnlPerfil.Controls.Add(this.txbNuevaPassword);
            this.pnlPerfil.Location = new System.Drawing.Point(808, 172);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(591, 371);
            this.pnlPerfil.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 404);
            this.panel1.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1011, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPerfil);
            this.Controls.Add(this.gpbSecciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les UTN - Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.gpbSecciones.ResumeLayout(false);
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Panel panel1;
    }
}