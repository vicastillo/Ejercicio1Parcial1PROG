using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Parcial1PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Total a pagar";


            Double precioarticulo, cantidad, total;

            Console.Write("Ingrese el precio del artículo que lleva: $");
            precioarticulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué cantidad de este artículo lleva usted?");
            cantidad = Double.Parse(Console.ReadLine());

            total = (precioarticulo * cantidad);

            Console.WriteLine("El total que usted debe pagar por su compra es: $" + total + ".");
            Console.WriteLine("GRACIAS POR SU COMPRA, VUELVA PRONTO.");

            Console.ReadKey();

        }
    }
}
