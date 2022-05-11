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
            if (!string.IsNullOrEmpty(txbContrasenaActual.Text) && 
                (!string.IsNullOrEmpty(txbNombreNuevo.Text) || !string.IsNullOrEmpty(txbNuevaPassword.Text) ) )
            {
                if(Sistema.ChequearPassword(Sistema.usuarioLogueado.Nombre, txbContrasenaActual.Text))
                {

                    this.CargarNombre();
                }
                else
                {
                    lblAdvertenciaPerfil.Visible = true;
                    lblAdvertenciaPerfil.Text = "Contrasena incorrecta, no se aplicaron los cambios";
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
    }
}
