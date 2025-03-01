using System;

namespace Proyecto.Parte2
{
    public class Desafio2
    {
        static int puntajeRecord = 0;
        static string jugadorRecord = "";

        public static void Ejecutar()
        {
            while (true)
            {
                Console.Write("Nombre del jugador: ");
                string nombre = Console.ReadLine();

                Console.Write("Puntaje obtenido: ");
                if (int.TryParse(Console.ReadLine(), out int puntaje))
                {
                    if (puntaje > puntajeRecord)
                    {
                        puntajeRecord = puntaje;
                        jugadorRecord = nombre;
                        Console.WriteLine("¡Nueva puntuación más alta! " + puntaje + " por " + nombre);
                    }
                    else
                    {
                        Console.WriteLine("El récord de " + puntajeRecord + " sigue en manos de " + jugadorRecord);
                    }
                }
                else
                {
                    Console.WriteLine("Puntaje inválido.");
                }

                Console.Write("¿Otro intento? (si/no): ");
                if (Console.ReadLine().ToLower() != "si") break;
            }
        }
    }
}

