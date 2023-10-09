using System;

namespace compradearticulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Compra de articulo");
            Console.WriteLine("--------------------");

            // Solicitar el precio del artículo
            Console.Write("Ingrese el precio del artículo: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Solicitar la cantidad a comprar
            Console.Write("Ingrese la cantidad que desea comprar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            // Calcular el total a pagar
            double total = precio * cantidad;

            // Mostrar el resultado
            Console.WriteLine("Total a pagar: " + total );

            Console.WriteLine("¡Gracias por su compra!");

            Console.ReadKey();
        }
    }
}

