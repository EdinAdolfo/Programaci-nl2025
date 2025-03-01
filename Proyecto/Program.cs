using System;
using Proyecto.Parte1;
using Proyecto.Parte2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elige una Parte (1 o 2):");
        int parte = int.Parse(Console.ReadLine());

        if (parte == 1)
        {
            Console.WriteLine("Elige un Desafío (1-3):");
            int desafio = int.Parse(Console.ReadLine());

            switch (desafio)
            {
                case 1: Proyecto.Parte1.Desafio1.Ejecutar(); break;
                case 2: Proyecto.Parte1.Desafio2.Ejecutar(); break;
                case 3: Proyecto.Parte1.Desafio3.Ejecutar(); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
        else if (parte == 2)
        {
            Console.WriteLine("Elige un Desafío (1-2):");
            int desafio = int.Parse(Console.ReadLine());

            switch (desafio)
            {
                case 1: Proyecto.Parte2.Desafio1.Ejecutar(); break;
                case 2: Proyecto.Parte2.Desafio2.Ejecutar(); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

