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
            if (((Button)sender).Text == "Admin")
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
                lblDatosIncorrectos.Visible = false;
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }            
        }
    }
}
