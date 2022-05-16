using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Producto
    {
        public Comida(string nombre, int cantidad, double valor) : base(nombre, cantidad, valor)
        {
        }

        public Comida(string nombre, double valor) : base(nombre, 1, valor)
        {

        }
    }
}
