using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del producto:");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el descuento:");
            int descuento = Convert.ToInt32(Console.ReadLine());
            double valorDescontable = (double)descuento / 100 * precio;
            double precioFinal = precio - valorDescontable;
            Console.WriteLine("El precio se queda en "+precioFinal+" euros.");
        }
    }
}
