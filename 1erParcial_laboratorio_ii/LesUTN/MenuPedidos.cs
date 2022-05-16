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
    public partial class MenuPedidos : Form
    {
        private Pedido pedido;
        private Label labelPedido;
        private bool esMesa;
        protected double total;
        public MenuPedidos(Button botonSender,Pedido pedido)
        {
            InitializeComponent();
            
            this.pedido = pedido;
            Text +=" "+botonSender.Text;
            labelPedido = (Label)botonSender.Tag;
            if (botonSender.Text.StartsWith("Mesa"))
            {
                esMesa = true;
            }
            
        }

        private void MenuPedidos_Load(object sender, EventArgs e)
        {
            lblNroOrden.Text += $" {pedido.nroOrden}";
            chbEstacionamiento.Checked = pedido.usaEstacionamiento;
            txbOrden.AppendText(pedido.Mostrar());
            
            foreach (Producto item in Sistema.inventario)
            {
                if (item.Cantidad > 0) 
                { 
                    if(item is Bebida)
                    {
                        ltbProductos.Items.Add(item);
                    }
                    if (esMesa && item is Comida)
                    {
                        ltbProductos.Items.Add(item);
                    }
                }
            }
            SetearTotal();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar la orden? Si no se remueven los productos del pedido, no se agregaran al stock","Cancelar Orden",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                labelPedido.Tag = null;
                labelPedido.BackColor = Color.LawnGreen;
                labelPedido.Text = "Libre";
                Close();
            }

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //TODO Al cobrar agregar la orden al richtextbox de Tickets, una forma de hacerlo seria la siguiente
            //((RichTextBox)this.Owner.Controls.Find("rtbFacturaciones", false)[0]).AppendText
            labelPedido.Tag = null;
        }

        
        private void SetearTotal()
        {
            total = 0;
            pedido.CalcularTotal(chbEstacionamiento.Checked);
            total = pedido.Total;
            if (rbtCredito.Checked == true)
            {
                total += total * .10;
            }
            lblTotal.Text = $"Total: ${total}";
            txbOrden.Clear();
            txbOrden.AppendText(pedido.Mostrar());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto bufferProducto;
            Producto productoSeleccionado = (Producto)ltbProductos.SelectedItem;
            if (productoSeleccionado is not null)
            {
                if(productoSeleccionado is Bebida)
                {
                    bufferProducto = new Bebida(productoSeleccionado.Nombre, productoSeleccionado.Valor);
                } else
                {
                    bufferProducto = new Comida(productoSeleccionado.Nombre, productoSeleccionado.Valor);
                }
                for (int i = 0; i < (int)nudCantidad.Value; i++)
                {
                    pedido = pedido + bufferProducto;
                }
                if(Sistema.GetProducto(productoSeleccionado).Cantidad == 0)
                {
                    ltbProductos.Items.Remove(productoSeleccionado);
                }
                SetearTotal();
                btnQuitar.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Producto bufferProducto;
            Producto productoSeleccionado = (Producto)ltbProductos.SelectedItem;
            if (productoSeleccionado is not null)
            {
                if (productoSeleccionado is Bebida)
                {
                    bufferProducto = new Bebida(productoSeleccionado.Nombre, productoSeleccionado.Valor);
                }
                else
                {
                    bufferProducto = new Comida(productoSeleccionado.Nombre, productoSeleccionado.Valor);
                }
                for (int i = 0; i < (int)nudCantidad.Value; i++)
                {
                    pedido = pedido - bufferProducto;
                }
                if (Sistema.GetProducto(productoSeleccionado).Cantidad == 1)
                {
                    ltbProductos.Items.Add(productoSeleccionado);
                }
                SetearTotal();
            }
        }


        private void ctr_CheckedChanged(object sender, EventArgs e)
        {
            SetearTotal();
        }

        private void ltbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto productoBuffer = (Producto)ltbProductos.SelectedItem;
            if (productoBuffer is not null)
            {
                btnAgregar.Enabled = true;
                if (pedido.GetProducto(productoBuffer) is not null)
                {
                    btnQuitar.Enabled = true;
                }
            }
        }

        private void txbOrden_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbOrden.Text))
            {
                btnCobrar.Enabled = true;
                btnQuitar.Enabled = true;
            }
            else
            {
                btnCobrar.Enabled = false;
                btnQuitar.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
