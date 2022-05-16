using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public static int nroUltimaOrden=0;
        public int nroOrden;
        public List<Producto> productosPedidos;
        private double total;
        public bool usaEstacionamiento;

        public Pedido()
        {
            productosPedidos = new List<Producto>();
            nroOrden = nroUltimaOrden+1;
            nroUltimaOrden = nroOrden;
            usaEstacionamiento = false;
        }

        public bool EstaVacio()
        {
            return productosPedidos.Count == 0;
        }

        public double Total 
        { 
            get 
            { 
                return total; 
            } 
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in productosPedidos)
            {
                sb.Append(item.Mostrar());
            }
            if (usaEstacionamiento)
            {
                sb.AppendLine("Estacionamiento \t\t $200");
            }
            return sb.ToString();
        }

        public void CalcularTotal(bool estacionamiento)
        {
            total = 0;
            usaEstacionamiento=estacionamiento;
            foreach (Producto item in productosPedidos)
            {
                total += item.Valor * item.Cantidad;
            }
            if (usaEstacionamiento)
            {
                total += 200;
            }
        }

        public Producto GetProducto(Producto producto)
        {
            if(this.productosPedidos.Count > 0) 
            { 
                foreach (Producto item in productosPedidos)
                {
                    if (producto == item)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static Pedido operator +(Pedido pedido, Producto producto)
        {
            Producto productoStock = Sistema.GetProducto(producto);
            Producto productoBuffer;
            if (productoStock is not null)
            {
                productoBuffer = pedido.GetProducto(productoStock);
                if (productoBuffer is null)
                {
                    pedido.productosPedidos.Add(producto);

                }
                else if (productoStock.Cantidad > 0)
                {
                    productoBuffer.Cantidad++;
                    productoStock.Cantidad--;
                }
            }
            return pedido;
        }

        public static Pedido operator -(Pedido pedido, Producto producto)
        {
            Producto productoStock = Sistema.GetProducto(producto);
            Producto productoBuffer;
            if (productoStock is not null)
            {
                productoBuffer = pedido.GetProducto(productoStock);
                if (productoBuffer is not null)
                {
                    if (productoBuffer.Cantidad-1 != 0)
                    {
                        productoBuffer.Cantidad--;
                        productoStock.Cantidad++;
                    }
                    else
                    {
                        productoBuffer.Cantidad--;
                        productoStock.Cantidad++;
                        pedido.productosPedidos.Remove(productoBuffer);
                    }
                }
            }
            return pedido;
        }
    }
}
