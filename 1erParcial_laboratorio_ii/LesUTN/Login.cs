using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesUTN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAutofill_Click(object sender, EventArgs e)
        {
            Usuario usuarioBuffer;
            Button btnBuffer = (Button)sender;
            if (btnBuffer.Text == "Admin")
            {
                usuarioBuffer = Sistema.GetAdministrador();
                txbNombre.Text = usuarioBuffer.Nombre;
                txbContrasena.Text = usuarioBuffer.Password;
            }
            else 
            {
                usuarioBuffer = Sistema.GetEmpleado();
                txbNombre.Text = usuarioBuffer.Nombre;
                txbContrasena.Text = usuarioBuffer.Password;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Sistema.ChequearPassword(txbNombre.Text, txbContrasena.Text))
            {
                txbNombre.Text = string.Empty;
                txbContrasena.Text = string.Empty;
                lblDatosIncorrectos.Visible = false;
                SoundPlayer sonidoLogueo = new SoundPlayer(Properties.Resources.efectoSonidoLogueo);
                sonidoLogueo.Play();
                this.Hide();
                MenuPrincipal menu = new MenuPrincipal(); 
                menu.Show(this);
                
            }
            else
            {
                lblDatosIncorrectos.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Sistema.CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
