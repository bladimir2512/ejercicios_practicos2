using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calcule el valor de π a partir de la serie infinita
            //π=4*(4/3+4/5+4/7+4/9+4/11+...)


            //definimos una cantidad para realizar aproximicaion
            int terminos = 100000;
            double pi = 0.0;

            for (int i = 0; i < terminos; i++)
            {
                double termino = 4.0 * (1.0 / (2.0 * i + 1));
                if (i % 2 == 0)
                {
                    pi += termino;
                }
                else
                {
                    pi -= termino;
                }
            }
            Console.WriteLine($"Aproximacion de π usando {terminos} terminos: {pi}");
            //no cerrar consola
            Console.ReadLine();
            Console.ReadKey();


        }

    }
}