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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAutofill_Click(object sender, EventArgs e)
        {
            Button btnBuffer = (Button)sender;
            if (btnBuffer.Text == "Admin")
            {   
                txbNombre.Text = "Don Pepe";
                txbContrasena.Text = "Pepe2015";
            }
            else 
            {
                txbNombre.Text = "Juancito";
                txbContrasena.Text = "RacingCampeon";
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Sistema.ChequearPassword(txbNombre.Text, txbContrasena.Text))
            {
                txbNombre.Text = null;
                txbContrasena.Text = null;
                lblDatosIncorrectos.Visible = false;
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
