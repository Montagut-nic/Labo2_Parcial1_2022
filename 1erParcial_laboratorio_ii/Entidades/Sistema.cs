using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Sistema
    {
        private static List<Producto> inventario;
        private static Dictionary<string,Usuario> listaDeUsuarios;
        public static Usuario usuarioLogueado;

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
            Usuario a1 = new Administrador("Don Pepe","Pepe2015");
            Usuario e1 = new Empleado("Juancito", "RacingCampeon");
            Usuario e2 = new Empleado("Esteban", "quito123");
            Usuario e3 = new Empleado("Nico", "VamosNiubel");

            Producto b1 = new Bebida("Coca Cola 500ml",30,200);
            Producto b2 = new Bebida("Agua sin gas 500ml",50,190);
            Producto b3 = new Bebida("Agua con gas 500ml", 50, 190);
            Producto b4 = new Bebida("Limonada",40,200);
            Producto b5 = new Bebida("Cerveza 750ml",200,350);
            Producto b6 = new Bebida("Martini", 70, 600);
            Producto b7 = new Bebida("Manhattan", 80, 700);
            Producto b8 = new Bebida("Negroni", 80, 800);

            Producto c1 = new Comida("Papas cheddar",150,700);
            Producto c2 = new Comida("Rabas",100,1200);
            Producto c3 = new Comida("Bastones de muzzarella", 100, 750);
            Producto c4 = new Comida("Quesadillas", 120, 900);
            Producto c5 = new Comida("Tabla de quesos", 200, 900);
            Producto c6 = new Comida("Tabla de fiambres", 100, 2200);
            Producto c7 = new Comida("Ensalada Cesar", 200, 750);
            Producto c8 = new Comida("Hamburguesa completa", 180, 900);

            listaDeUsuarios = new Dictionary<string, Usuario>();
            listaDeUsuarios.Add(a1.Nombre, a1);
            listaDeUsuarios.Add(e1.Nombre, e1);
            listaDeUsuarios.Add(e2.Nombre, e2);
            listaDeUsuarios.Add(e3.Nombre, e3);

            inventario = new List<Producto>();
            inventario += b1;
            inventario += b2;
            inventario += b3;
            inventario += b4;
            inventario += b5;
            inventario += b6;
            inventario += b7;
            inventario += b8;

            inventario += c1;
            inventario += c2;
            inventario += c3;
            inventario += c4;
            inventario += c5;
            inventario += c6;
            inventario += c7;
            inventario += c8;
        }
    }
}
