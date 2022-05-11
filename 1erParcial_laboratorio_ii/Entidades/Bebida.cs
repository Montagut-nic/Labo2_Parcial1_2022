using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida : Producto
    {
        public Bebida(string nombre, int cantidad, double valor) : base(nombre, cantidad, valor)
        {
        }
    }
}
