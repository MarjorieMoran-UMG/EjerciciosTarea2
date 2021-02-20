using System;

namespace SemanaLaboral
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("--------------------DÍA DE LA SEMANA-------------------");
            Console.WriteLine("Por favor ingrese un día de la semana: \t ");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Es un día laboral");
                    break;
                case "Martes":
                    Console.WriteLine("Es un día laboral");
                    break;
                case "Miércoles":
                    Console.WriteLine("Es un día laboral");
                    break;
                case "Jueves":
                    Console.WriteLine("Es un día laboral");
                    break;
                case "Viernes":
                    Console.WriteLine("Es un día laboral");
                    break;
                case "Sábado":
                    Console.WriteLine("No es un día laboral");
                    break;
                case "Domingo":
                    Console.WriteLine("No es un día laboral");
                    break;
            }
        }
    }
}
