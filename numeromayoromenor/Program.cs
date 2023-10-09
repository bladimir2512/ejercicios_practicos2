using System;

namespace numeromayoromenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int mayor = Math.Max(numero1, Math.Max(numero2, numero3));
            int menor = Math.Min(numero1, Math.Min(numero2, numero3));

            Console.WriteLine("El mayor número es: " + mayor);
            Console.WriteLine("El menor número es: " + menor);
            Console.ReadKey();

        }
    }
}
