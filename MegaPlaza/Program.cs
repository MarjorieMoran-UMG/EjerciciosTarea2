using System;

namespace MegaPlaza
{
    class MainClass
    {
        public static void Main (string[] args)
       
        {
            double cantidad, pagocondesct;
            const double descuento = 0.20;
       
            Console.WriteLine("*****************MEGAPLAZA*****************");
            Console.WriteLine("****La plaza con los mejores descuentos****");
            Console.WriteLine("Ingrese el total de la compra: \t ");
            cantidad = Convert.ToDouble (Console.ReadLine());

            if (cantidad >= 300)
            {       pagocondesct = (cantidad * descuento);
                Console.Write("Su total a pagar con descuento es de: \t " + (pagocondesct));
            } 
            else 
                Console.Write("Su total a pagar es de: \t " + (cantidad));

        Console.ReadKey();
        }
    }
}
