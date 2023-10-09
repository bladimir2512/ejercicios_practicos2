using System;

namespace sumadeumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuatro números:");

            Console.Write("Número 1: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 2: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 3: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 4: ");
            double numero4 = Convert.ToDouble(Console.ReadLine());

            double sumaPrimerosNumeros = numero1 + numero2;
            double productoTercerCuartoNumeros = numero3 * numero4;

            Console.WriteLine("La suma de los dos primeros números es: " + sumaPrimerosNumeros);
            Console.WriteLine("El producto del tercer y cuarto número es: " + productoTercerCuartoNumeros );

            Console.ReadKey();
        }
    }
}
