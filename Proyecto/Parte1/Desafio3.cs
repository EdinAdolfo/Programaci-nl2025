using System;

namespace Proyecto.Parte1
{
    public class Desafio3
    {
        static void Sumar()
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Suma: " + (n1 + n2));
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Ingresa solo números enteros.");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }

        public static void Ejecutar()
        {
            Sumar();
        }
    }
}
