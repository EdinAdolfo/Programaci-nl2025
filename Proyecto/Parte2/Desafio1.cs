using System;

namespace Proyecto.Parte2
{
    public class Desafio1
    {
        public static void Ejecutar()
        {
            string usuarioRegistrado = "";
            string contraseñaRegistrada = "";

            Console.WriteLine("Registrarse");
            Console.Write("Ingrese un nombre de usuario: ");
            usuarioRegistrado = Console.ReadLine();

            Console.Write("Ingrese una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("¡Registro exitoso!");

            Console.WriteLine("\nIniciar sesión");
            Console.Write("Ingrese su nombre de usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseñaIngresada = Console.ReadLine();

            if (usuarioIngresado == usuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
            {
                Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido " + usuarioIngresado + "!");
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
            }

            Console.ReadLine();
        }
    }
}

