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
        bool seEstaDeslogueando;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarNombre();
            SetearTags();
            CargardgvStockInventario();
            CargarltbRellenarProducto();
            CargarltbUsuarios();
            rtbFacturaciones.Text = Sistema.facturaciones;
            if (Sistema.usuarioLogueado is Empleado)
            {
                btnUsuarios.Visible = false;
                this.BackColor = Color.Salmon;
            }
        }

        private void CargarNombre()
        {
            lblSaludo.Text = $"Hola {Sistema.usuarioLogueado.Nombre}";
            txbNombreNuevo.PlaceholderText = $"{Sistema.usuarioLogueado.Nombre}";
        }

        private void CargardgvStockInventario()
        {
            dgvStockInventario.DataSource = null;
            dgvStockInventario.DataSource = Sistema.inventario;
        }

        private void CargarltbRellenarProducto()
        {
            ltbRellenarProducto.Items.Clear();
            foreach (Producto item in Sistema.inventario)
            {
                ltbRellenarProducto.Items.Add(item);
            }
        }

        private void CargarltbUsuarios()
        {
            ltbUsuarios.Items.Clear();
            foreach (Usuario item in Sistema.listaDeUsuarios.Values)
            {
                if (item != Sistema.usuarioLogueado)
                {
                    ltbUsuarios.Items.Add(item);
                }
            }
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
            btnTickets.Tag = pnlTickets;
            btnUsuarios.Tag = pnlUsuarios;

        }

        private void txbContrasenaActual_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbContrasenaActual.Text))
            {
                btnActualizar.Enabled = true;
            }
            else
            {
                btnActualizar.Enabled = false;
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


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar sesion?","Cerrar Sesion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sistema.facturaciones = rtbFacturaciones.Text;
                seEstaDeslogueando=true;
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
            if (Sistema.usuarioLogueado is Administrador)
            {
                btnUsuarios.Enabled = true;
            }
            btnBuffer.Enabled = false;

            pnlBar.Visible = false;
            pnlPerfil.Visible = false;
            pnlStock.Visible = false;
            pnlTickets.Visible = false;
            pnlUsuarios.Visible = false;
            pnlBuffer.Visible = true;

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

        private void btnAgregarNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto;
            if( !string.IsNullOrWhiteSpace(txbNuevoProductoNombre.Text) && 
                (rbtNuevoProductoEsBebida.Checked || rbtNuevoProductoEsComida.Checked) )
            {
                if (rbtNuevoProductoEsBebida.Checked)
                {
                    nuevoProducto = new Bebida(txbNuevoProductoNombre.Text,(int)nudNuevoProductoCantidad.Value,(double)nudValorNuevoProducto.Value);
                }
                else
                {
                    nuevoProducto = new Comida(txbNuevoProductoNombre.Text, (int)nudNuevoProductoCantidad.Value, (double)nudValorNuevoProducto.Value);
                }
                if(Sistema.GetProducto(nuevoProducto) is null && 
                MessageBox.Show($"Seguro desea agregar {nuevoProducto.Cantidad} {nuevoProducto.Nombre} por ${nuevoProducto.Valor}?","Agregar Nuevo Producto?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Sistema.inventario.Add(nuevoProducto);
                    CargardgvStockInventario();
                    CargarltbRellenarProducto();
                }
            }
        }

        

        private void rbtNuevoProducto_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregarNuevoProducto.Enabled = true;
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!seEstaDeslogueando)
            {
                Application.Exit();
            }
            
        }

        private void btnRellenarStock_Click(object sender, EventArgs e)
        {
            Sistema.GetProducto((Producto)ltbRellenarProducto.SelectedItem).Cantidad+=(int)nudCantidadRellenarStock.Value;
        }

        private void ltbRellenarProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ltbRellenarProducto.SelectedItem != null)
            {
                btnRellenarStock.Enabled = true;
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            Usuario usuarioBuffer = (Usuario)ltbUsuarios.SelectedItem;
            if (usuarioBuffer is not null)
            {
                if (!string.IsNullOrWhiteSpace(txbModificarPassword.Text))
                {
                    usuarioBuffer.Password = txbModificarPassword.Text;
                }
                if (!string.IsNullOrWhiteSpace(txbModificarNombre.Text))
                {
                    Sistema.listaDeUsuarios.Remove(usuarioBuffer.Nombre);
                    usuarioBuffer.Nombre = txbModificarNombre.Text;
                    Sistema.listaDeUsuarios.Add(usuarioBuffer.Nombre, usuarioBuffer);
                    CargarltbUsuarios();
                }
            }

        }

        private void txbModificarNombreOPassword_TextChanged(object sender, EventArgs e)
        {
            if( ltbUsuarios.SelectedItem is not null &&
                (!string.IsNullOrWhiteSpace(txbModificarNombre.Text) || 
                !string.IsNullOrWhiteSpace(txbModificarPassword.Text)) )
            {
                btnConfirmarCambios.Enabled = true;
            }
            else
            {
                btnConfirmarCambios.Enabled = false;
            }
        }

        private void pnlStock_VisibleChanged(object sender, EventArgs e)
        {
            if(Sistema.usuarioLogueado is Empleado)
            {
                gpbStockAdministrador.Visible = false;
            }
        }

        private void btnGuardarFacturaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarNuevoUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioNuevo;
            if (!string.IsNullOrWhiteSpace(txbNombreNuevoUsuario.Text) 
                && !string.IsNullOrWhiteSpace(txbPasswordNuevoUsuario.Text) )
            {
                if (chbEsAdministrador.Checked)
                {
                    usuarioNuevo = new Administrador(txbNombreNuevoUsuario.Text, txbPasswordNuevoUsuario.Text);
                }
                else
                {
                    usuarioNuevo = new Empleado(txbNombreNuevoUsuario.Text, txbPasswordNuevoUsuario.Text);
                }
                Sistema.listaDeUsuarios.Add(usuarioNuevo.Nombre, usuarioNuevo);
                CargarltbUsuarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ltbUsuarios.SelectedItem is not null && 
                MessageBox.Show("Seguro desea eliminar a este usuario?","Eliminar usuario",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Sistema.listaDeUsuarios.Remove(((Usuario)ltbUsuarios.SelectedItem).Nombre);
                CargarltbUsuarios();
            }
        }

        private void txbNuevoUsuario_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbPasswordNuevoUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txbNombreNuevoUsuario.Text))
            {
                btnAgregarNuevoUsuario.Enabled = true;
            }
            else
            {
                btnAgregarNuevoUsuario.Enabled = false;
            }
        }

        private void ltbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
