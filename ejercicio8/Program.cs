
using System;

namespace ejercicio8
{
    class Program
    {
        // Método para verificar si un número es perfecto
        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            return sumaDivisores == numero;
        }

        // Método para mostrar los números perfectos y sus factores
        static void MostrarNumerosPerfectos()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (EsNumeroPerfecto(i))
                {
                    Console.WriteLine($"Número Perfecto: {i}");
                    Console.Write("Factores: 1");
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            Console.Write($" + {j}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para verificar si es perfecto:");
            int numeroIngresado = int.Parse(Console.ReadLine());

            if (EsNumeroPerfecto(numeroIngresado))
            {
                Console.WriteLine($"El número {numeroIngresado} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"El número {numeroIngresado} no es un número perfecto.");
            }

            Console.WriteLine("Números perfectos entre 1 y 1000:");
            MostrarNumerosPerfectos();

            Console.ReadKey();
        }
    }
}
