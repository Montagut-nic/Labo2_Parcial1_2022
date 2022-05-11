using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public Empleado(string nombre, string password) : base(nombre, password)
        {
        }
    }
}
