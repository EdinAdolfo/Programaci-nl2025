using System;

namespace Proyecto.Parte1
{
    public class Calculadora
    {
        public int Sumar(int n1, int n2) => n1 + n2;
        public int Restar(int n1, int n2) => n1 - n2;
        public int Multiplicar(int n1, int n2) => n1 * n2;

        public int Dividir(int n1, int n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
                return 0;
            }
        }
    }

    public class Desafio2
    {
        public static void Ejecutar()
        {
            Calculadora c = new Calculadora();

            Console.WriteLine("Ingrese el primer número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma: " + c.Sumar(x, y));
            Console.WriteLine("Resta: " + c.Restar(x, y));
            Console.WriteLine("Multiplicación: " + c.Multiplicar(x, y));
            Console.WriteLine("División: " + c.Dividir(x, y));
        }
    }
}
