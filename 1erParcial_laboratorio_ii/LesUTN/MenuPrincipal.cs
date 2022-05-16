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
            CargarNombre();
            SetearTags();
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
            Button btnBuffer = (Button)sender;
            Panel pnlBuffer = (Panel)btnBuffer.Tag;

            btnPerfil.Enabled = true;
            btnBar.Enabled = true;
            btnStock.Enabled = true;
            btnTickets.Enabled = true;
            btnUsuarios.Enabled = true;
            btnBuffer.Enabled = false;

            pnlBar.Visible = false;
            pnlPerfil.Visible = false;
            pnlBuffer.Visible = true;

        }

        private void SetearTags()
        {
            btnMesa1.Tag = lblDisponibilidad1;
            btnMesa2.Tag = lblDisponibilidad2;
            btnMesa3.Tag = lblDisponibilidad3;
            btnMesa4.Tag = lblDisponibilidad4;
            btnMesa5.Tag = lblDisponibilidad5;
            btnMesa6.Tag = lblDisponibilidad6;
            btnMesa7.Tag = lblDisponibilidad7;
            btnMesa8.Tag = lblDisponibilidad8;
            btnMesa9.Tag = lblDisponibilidad9;
            btnMesa10.Tag = lblDisponibilidad10;
            btnMesa11.Tag = lblDisponibilidad11;
            btnMesa12.Tag = lblDisponibilidad12;
            btnMesa13.Tag = lblDisponibilidad13;
            btnMesa14.Tag = lblDisponibilidad14;
            btnMesa15.Tag = lblDisponibilidad15;
            btnBarra1.Tag = lblDisponibilidad16;
            btnBarra2.Tag = lblDisponibilidad17;
            btnBarra3.Tag = lblDisponibilidad18;
            btnBarra4.Tag = lblDisponibilidad19;
            btnBarra5.Tag = lblDisponibilidad20;

            btnPerfil.Tag = pnlPerfil;
            btnBar.Tag = pnlBar;
            btnStock.Tag = pnlStock;

        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            Button btnBuffer = (Button)sender;
            Label lblBuffer = (Label)btnBuffer.Tag;
            if ( lblBuffer.Text == "Libre")
            {
                lblBuffer.Text = "Ocupada";
                lblBuffer.BackColor = Color.Red;
                lblBuffer.Tag = new Pedido();
            }
            MenuPedidos menu = new MenuPedidos(btnBuffer, (Pedido)lblBuffer.Tag);
            menu.Show(this);

        }
    }
}
