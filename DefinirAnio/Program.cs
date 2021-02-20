using System;

namespace DefinirAnio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Enero = 1;
            const int Febrero = 2;
            const int Marzo = 3;
            

            int daysInEnero = System.DateTime.DaysInMonth(2002, Enero);
            Console.WriteLine(daysInEnero);

            int daysInFebrero = System.DateTime.DaysInMonth(2012, Febrero);
            Console.WriteLine(daysInFebrero);

            int daysInMarzoLeap = System.DateTime.DaysInMonth(2020, Marzo);
            Console.WriteLine(daysInMarzoLeap);

            Console.ReadKey();
        }
    }
}
