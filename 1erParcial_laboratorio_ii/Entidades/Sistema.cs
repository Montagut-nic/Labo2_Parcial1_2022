using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Sistema
    {
        public static List<Producto> inventario;
        public static Dictionary<string,Usuario> listaDeUsuarios;
        public static Usuario usuarioLogueado;
        public static string facturaciones;

        public static bool ChequearPassword(string nombre, string password)
        {
            Usuario buffer;
            if (listaDeUsuarios.TryGetValue(nombre, out buffer) && buffer.Password==password)
            {
                usuarioLogueado = buffer;
                return true;
            }
            else 
            {
                return false; 
            }
        }

        public static Producto GetProducto(Producto producto)
        {
            if (producto is not null)
            {
                foreach (Producto item in inventario)
                {
                    if (producto == item)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static Administrador GetAdministrador()
        {
            foreach (Usuario item in listaDeUsuarios.Values)
            {
                if (item is Administrador)
                {
                    return (Administrador)item;
                }
            }
            return null;
        }

        public static Empleado GetEmpleado()
        {
            foreach (Usuario item in listaDeUsuarios.Values)
            {
                if (item is Empleado)
                {
                    return (Empleado)item;
                }
            }
            return null;
        }

        public static bool EsSoloLetras(this string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsLetter(c) && !(c == ' ')) 
                {
                    return false;
                }   
            }
            return true;
        }

        public static void CambiarNombreDelUsuarioLogueado (string nuevoNombre)
        {
            Usuario buffer;
            if (usuarioLogueado.Nombre != nuevoNombre)
            {
                buffer = listaDeUsuarios[usuarioLogueado.Nombre];
                listaDeUsuarios.Remove(usuarioLogueado.Nombre);
                buffer.Nombre = nuevoNombre;
                listaDeUsuarios.Add(buffer.Nombre, buffer);
                usuarioLogueado = listaDeUsuarios[nuevoNombre];
            }
        }

        public static void CambiarPasswordDelUsuarioLogueado(string nuevaContrasena)
        {
            if (usuarioLogueado.Password != nuevaContrasena)
            {
                listaDeUsuarios[usuarioLogueado.Nombre].Password = nuevaContrasena;
                usuarioLogueado = listaDeUsuarios[usuarioLogueado.Nombre];
            }
        }

        public static void CargarDatos()
        {
            inventario = new List<Producto>();
            listaDeUsuarios = new Dictionary<string, Usuario>();

            listaDeUsuarios.Add("Don Pepe", new Administrador("Don Pepe", "Pepe2015"));
            listaDeUsuarios.Add("Juancito", new Empleado("Juancito", "RacingCampeon"));
            listaDeUsuarios.Add("Esteban", new Empleado("Esteban", "quito123"));
            listaDeUsuarios.Add("Nico", new Empleado("Nico", "VamosNiubel"));

            inventario += new Bebida("Coca Cola 500ml",30,200);
            inventario += new Bebida("Agua sin gas 500ml",50,190);
            inventario += new Bebida("Agua con gas 500ml", 50, 190);
            inventario += new Bebida("Limonada",40,200);
            inventario += new Bebida("Cerveza 750ml",200,350);
            inventario += new Bebida("Martini", 70, 600);
            inventario += new Bebida("Manhattan", 80, 700);
            inventario += new Bebida("Negroni", 80, 800);

            inventario += new Comida("Papas cheddar",150,700);
            inventario += new Comida("Rabas",100,1200);
            inventario += new Comida("Bastones de muzzarella", 100, 750);
            inventario += new Comida("Quesadillas", 120, 900);
            inventario += new Comida("Tabla de quesos", 200, 900);
            inventario += new Comida("Tabla de fiambres", 100, 2200);
            inventario += new Comida("Ensalada Cesar", 200, 750);
            inventario += new Comida("Hamburguesa completa", 180, 900);

        }
    }
}
