using System.Collections.Generic;

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

        protected string Nombre 
        {
            set 
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.nombre = value; 
                }
                
            }
            get 
            { 
                return nombre; 
            } 
        }

        protected int Cantidad 
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

        protected double Valor
        {
            set
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
            foreach (Producto item in productos)
            {
                if(item == producto)
                {
                    item.Cantidad++;
                    return productos;
                }
            }
            
            productos.Add(producto);
            return productos;                
        }

        public static bool operator ==(Producto productoA, Producto productoB)
        {
            return (productoA.GetType() == productoB.GetType() && productoA.ToString() == productoB.ToString());
        }

        public static bool operator !=(Producto productoA, Producto productoB)
        {
            return !(productoA == productoB);
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
