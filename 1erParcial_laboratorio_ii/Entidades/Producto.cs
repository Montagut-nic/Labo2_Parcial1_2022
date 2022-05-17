using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        private int cantidad;
        private string nombre;
        private double valor;

        public Producto(string nombre, int cantidad, double valor)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Valor = valor;

        }

        public string Nombre 
        {
            private set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value; 
                }
                
            }
            get 
            { 
                return nombre; 
            } 
        }

        public int Cantidad 
        {
            set 
            {
                if(value >= 0)
                {
                    this.cantidad = value;
                }
            }
            get 
            { 
                return cantidad; 
            }
        }

        public double Valor
        {
            protected set
            {
                if (value >= 0)
                {
                    this.valor = value;
                }
            }
            get
            {
                return valor;
            }
            
        }


        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            if (producto is not null && productos != null) 
            { 
                foreach (Producto item in productos)
                {
                    if (item == producto)
                    {
                        item.Cantidad++;
                        return productos;
                    }
                }
                productos.Add(producto);
            }
            return productos;
        }

        public static bool operator ==(Producto productoA, Producto productoB)
        {
            return productoA.Nombre == productoB.Nombre;
        }

        public static bool operator !=(Producto productoA, Producto productoB)
        {
            return !(productoA == productoB);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine($"\t Cantidad: {Cantidad} \t Precio unitario: ${Valor}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Producto producto &&
                   Nombre == producto.Nombre &&
                   obj.GetType() == producto.GetType() &&
                   obj != null;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(cantidad, nombre, valor, Nombre, Cantidad, Valor);
        }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
