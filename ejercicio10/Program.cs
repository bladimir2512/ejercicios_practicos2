using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número binario: ");
            string binarioStr = Console.ReadLine();

            int decimalValue = BinarioADecimal(binarioStr);
            string hexadecimalValue = DecimalAHexadecimal(decimalValue);
            string octalValue = DecimalAOctal(decimalValue);

            Console.WriteLine($"Equivalente decimal: {decimalValue}");
            Console.WriteLine($"Equivalente hexadecimal: {hexadecimalValue}");
            Console.WriteLine($"Equivalente octal: {octalValue}");
        }

        static int BinarioADecimal(string binario)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                int digit = binario[i] - '0';
                decimalValue += digit * (int)Math.Pow(2, power);
                power++;
            }

            return decimalValue;
        }

        static string DecimalAHexadecimal(int decimalValue)
        {
            string hexadecimalValue = "";

            while (decimalValue > 0)
            {
                int remainder = decimalValue % 16;
                char hexDigit = (remainder < 10) ? (char)(remainder + '0') : (char)(remainder - 10 + 'A');
                hexadecimalValue = hexDigit + hexadecimalValue;
                decimalValue /= 16;
            }

            return hexadecimalValue;
        }

        static string DecimalAOctal(int decimalValue)
        {
            string octalValue = "";

            while (decimalValue > 0)
            {
                int remainder = decimalValue % 8;
                octalValue = remainder + octalValue;
                decimalValue /= 8;
            }

            return octalValue;

            Console.ReadKey();
        }
    }
}
