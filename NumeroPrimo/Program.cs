using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool result;

            Program ob = new Program();

            Console.Write("Introduce un número: ");
            num = int.Parse(Console.ReadLine());

            result = ob.esPrimo(num);

            Console.WriteLine();
            Console.WriteLine("El {0} {1}", num, (result ? "es primo" : "no es primo"));
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private bool esPrimo(int num)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < num)
            {
                resto = num % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }
    }
}

