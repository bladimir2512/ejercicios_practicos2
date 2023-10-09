namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sacarla suma de numeros paresde un rango de valoresque el usuario indique 
            int n1, n2, total = 0;
            bool banderan1 = false, banderan2 = false;
            Console.WriteLine("ingrese el valor de n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de n2");
            n2 = int.Parse(Console.ReadLine());


            if (n1 >= 0 && n1 < n2)
            {
                banderan1 = true;

            }
            else
            {
                Console.WriteLine("n1 no cumple con la condicion");
            }


            if (n2 > n1)
            {
                banderan2 = true;
            }
            else
            {
                Console.WriteLine("n2 no cumple con la condicion");

            }

            if ((banderan1 && banderan2))
            {
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2 == 0)
                    {
                        total = total + i;
                    }
                }
                Console.WriteLine("la suma de los numeros  pares dentro del rango es: " + total);
            }
        }
    }

}   