using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesUTN
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CargarNombre();
            if(Sistema.usuarioLogueado is Empleado)
            {

            }
        }

        private void txbContrasenaActual_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbContrasenaActual.Text))
            {
                btnActualizar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbContrasenaActual.Text) && 
                (!string.IsNullOrWhiteSpace(txbNombreNuevo.Text) || !string.IsNullOrWhiteSpace(txbNuevaPassword.Text) ) )
            {
                if(Sistema.ChequearPassword(Sistema.usuarioLogueado.Nombre, txbContrasenaActual.Text))
                {
                    if(!string.IsNullOrWhiteSpace(txbNuevaPassword.Text) && txbNuevaPassword.Text != txbContrasenaActual.Text)
                    {
                        Sistema.CambiarPasswordDelUsuarioLogueado(txbNuevaPassword.Text);
                    }
                    if(!string.IsNullOrWhiteSpace(txbNombreNuevo.Text) && txbNombreNuevo.Text != Sistema.usuarioLogueado.Nombre)
                    {
                        Sistema.CambiarNombreDelUsuarioLogueado(txbNombreNuevo.Text);
                        CargarNombre();
                    }
                    txbContrasenaActual.Text = null;
                    txbNombreNuevo.Text = null;
                    txbNuevaPassword.Text = null;
                }
                else
                {
                    lblAdvertenciaPerfil.Visible = true;
                    lblAdvertenciaPerfil.Text = "Contrasena incorrecta, no se aplicaron los cambios";
                    txbContrasenaActual.Text = null;
                }
            }
            else
            {
                lblAdvertenciaPerfil.Visible = true;
                lblAdvertenciaPerfil.Text = "Complete los datos necesarios faltantes para actualizar";
            }
        }

        private void CargarNombre()
        {
            lblSaludo.Text = $"Hola {Sistema.usuarioLogueado.Nombre}";
            txbNombreNuevo.PlaceholderText = $"{Sistema.usuarioLogueado.Nombre}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar sesion?","Cerrar Sesion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Perfil":
                    btnPerfil.Enabled=false;
                    btnBar.Enabled = true;
                    btnStock.Enabled = true;
                    btnTickets.Enabled = true;
                    btnUsuarios.Enabled = true;

                    pnlPerfil.Visible = true;
                    break;
                case "Bar":
                    btnPerfil.Enabled = true;
                    btnBar.Enabled = false;
                    btnStock.Enabled = true;
                    btnTickets.Enabled = true;
                    btnUsuarios.Enabled = true;

                    pnlPerfil.Visible = false;
                    break;
                case "Stock":
                    btnPerfil.Enabled = true;
                    btnBar.Enabled = true;
                    btnStock.Enabled = false;
                    btnTickets.Enabled = true;
                    btnUsuarios.Enabled = true;

                    pnlPerfil.Visible = false;
                    break;
                case "Tickets":
                    btnPerfil.Enabled = true;
                    btnBar.Enabled = true;
                    btnStock.Enabled = true;
                    btnTickets.Enabled = false;
                    btnUsuarios.Enabled = true;

                    pnlPerfil.Visible = false;
                    break;
                case "Usuarios":
                    btnPerfil.Enabled = true;
                    btnBar.Enabled = true;
                    btnStock.Enabled = true;
                    btnTickets.Enabled = true;
                    btnUsuarios.Enabled = false;

                    pnlPerfil.Visible = false;
                    break;
            }
        }
    }
}
