namespace LesUTN
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbContrasena = new System.Windows.Forms.TextBox();
            this.btnAutofillAdmin = new System.Windows.Forms.Button();
            this.btnAutofillEmpleado = new System.Windows.Forms.Button();
            this.lblDatosIncorrectos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Silver;
            this.btnEntrar.Location = new System.Drawing.Point(182, 210);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 29);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(12, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContrasena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContrasena.Location = new System.Drawing.Point(12, 144);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(83, 20);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contrasena";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(12, 91);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Ingrese su nombre";
            this.txbNombre.Size = new System.Drawing.Size(264, 27);
            this.txbNombre.TabIndex = 3;
            // 
            // txbContrasena
            // 
            this.txbContrasena.Location = new System.Drawing.Point(12, 167);
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '*';
            this.txbContrasena.PlaceholderText = "Ingrese su contrasena";
            this.txbContrasena.Size = new System.Drawing.Size(264, 27);
            this.txbContrasena.TabIndex = 4;
            // 
            // btnAutofillAdmin
            // 
            this.btnAutofillAdmin.Location = new System.Drawing.Point(341, 118);
            this.btnAutofillAdmin.Name = "btnAutofillAdmin";
            this.btnAutofillAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnAutofillAdmin.TabIndex = 5;
            this.btnAutofillAdmin.Text = "Admin";
            this.btnAutofillAdmin.UseVisualStyleBackColor = true;
            this.btnAutofillAdmin.Click += new System.EventHandler(this.btnAutofill_Click);
            // 
            // btnAutofillEmpleado
            // 
            this.btnAutofillEmpleado.Location = new System.Drawing.Point(341, 83);
            this.btnAutofillEmpleado.Name = "btnAutofillEmpleado";
            this.btnAutofillEmpleado.Size = new System.Drawing.Size(94, 29);
            this.btnAutofillEmpleado.TabIndex = 6;
            this.btnAutofillEmpleado.Text = "Empleado";
            this.btnAutofillEmpleado.UseVisualStyleBackColor = true;
            this.btnAutofillEmpleado.Click += new System.EventHandler(this.btnAutofill_Click);
            // 
            // lblDatosIncorrectos
            // 
            this.lblDatosIncorrectos.AutoSize = true;
            this.lblDatosIncorrectos.BackColor = System.Drawing.Color.Black;
            this.lblDatosIncorrectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatosIncorrectos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosIncorrectos.ForeColor = System.Drawing.Color.Red;
            this.lblDatosIncorrectos.Location = new System.Drawing.Point(12, 25);
            this.lblDatosIncorrectos.Name = "lblDatosIncorrectos";
            this.lblDatosIncorrectos.Size = new System.Drawing.Size(322, 22);
            this.lblDatosIncorrectos.TabIndex = 7;
            this.lblDatosIncorrectos.Text = "Nombre de usuario o contrasena incorrectos";
            this.lblDatosIncorrectos.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Location = new System.Drawing.Point(341, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDatosIncorrectos);
            this.Controls.Add(this.btnAutofillEmpleado);
            this.Controls.Add(this.btnAutofillAdmin);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEntrar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les UTN - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbContrasena;
        private System.Windows.Forms.Button btnAutofillAdmin;
        private System.Windows.Forms.Button btnAutofillEmpleado;
        private System.Windows.Forms.Label lblDatosIncorrectos;
        private System.Windows.Forms.Button btnSalir;
    }
}
