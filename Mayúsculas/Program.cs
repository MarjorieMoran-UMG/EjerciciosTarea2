using System;

namespace Mayúsculas
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracter;
            Console.WriteLine("---------CARACTER---------");
            Console.WriteLine("Ingrese un caracter: \t \t");
            caracter = Console.ReadLine();
            if (caracter == "Q" || caracter == "W" || caracter == "E" || caracter == "R" || caracter == "T" || caracter == "Y" ||
                caracter == "U" || caracter == "I" || caracter == "O" || caracter == "P" || caracter == "A" || caracter == "S" ||
                caracter == "D" || caracter == "F" || caracter == "G" || caracter == "H" || caracter == "J" || caracter == "K" ||
                caracter == "L" || caracter == "Ñ" || caracter == "Z" || caracter == "X" || caracter == "C" || caracter == "V" ||
                caracter == "B" || caracter == "N" || caracter == "M")
            {
                Console.WriteLine("El caracter ingresado ES UNA LETRA MAYUSCULA");
            }
            else
            {
                Console.WriteLine("El caracter ingresado NO ES UNA LETRA MAYUSCULA");
            }
            Console.ReadKey();
        }
    }
}