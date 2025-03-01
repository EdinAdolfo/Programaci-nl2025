using System;

namespace Proyecto.Parte1
{
    public class Desafio1
    {
        static void Calc()
        {
            Console.WriteLine("Hola, ingresar datos");
            Console.Write("Nombre: ");
            string n = Console.ReadLine();
            Console.Write("Mes 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Mes 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Mes 3: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + n + ", ganaste " + (a + b + c) + " y promediaste " + (a + b + c) / 3);
        }

        public static void Ejecutar()
        {
            Calc();
        }
    }
}

