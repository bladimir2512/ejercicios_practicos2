using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la matriz: ");
        int size = int.Parse(Console.ReadLine());

        int[] numeros = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }

        Console.WriteLine($"La suma de los números en la matriz es: " + suma);
        Console.ReadKey();

    }
}
