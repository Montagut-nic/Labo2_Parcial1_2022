using System;

namespace Entidades
{
    public abstract class Usuario
    {
        private string password;
        private string nombre;

        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public string Password 
        {
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.password = value;
                }
            }

            get 
            { 
                return password; 
            } 
        }

        public string Nombre
        {
            set 
            {
                if(value.EsSoloLetras() && !string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value; 
                }
            }

            get 
            {
                return this.nombre; 
            }
        }

        public static bool operator ==(Usuario usuarioA, Usuario usuarioB)
        {
            return usuarioA.Nombre == usuarioB.Nombre && usuarioA.Password == usuarioB.Password &&usuarioA.GetType() == usuarioB.GetType();
        }

        public static bool operator !=(Usuario usuarioA, Usuario usuarioB)
        {
            return !(usuarioA == usuarioB);
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
