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
        public List<Producto> pedidos;

        public Pedido()
        {
            pedidos = new List<Producto>();
            nroOrden = nroUltimaOrden+1;
            nroUltimaOrden = nroOrden;
        }
    }
}
