using System;

namespace SalarioSemanal
{
    class Program
    {
        public static void Main(string[] args)

        {
            double horas, total, extra, totalconextras, horaextra, horaordinaria;
            const int ordinarias = 16, extraordinarias = 20;

            Console.WriteLine("--------------------------SALARIO SEMANAL----------------------------");
            Console.WriteLine("--------------Pago de horas ordinarias y extraordinarias-------------");
            Console.WriteLine("Ingrese el total de horas laboradas: \t \t \t \t");
            horas = Convert.ToDouble(Console.ReadLine());

            if (horas <= 40)
            {
                total = (ordinarias * horas);
                Console.Write("El salario semanal del empleado es: \t \t \t \t " + (total));
            }
            else
            {
                extra = (horas - 40);
                horaextra = (extra * extraordinarias);
                horaordinaria = (40 * ordinarias);
                totalconextras = (horaextra + horaordinaria);
                Console.Write("El salario semanal del empleado con horas extra es: \t " + (totalconextras));

            Console.ReadKey();
             }
        }
    }
}
