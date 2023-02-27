using System;

namespace conversor_euro_pesetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de euros:");
            double euros = Convert.ToDouble(Console.ReadLine());
            double pesetas = euros * (double)166;
            Console.WriteLine(euros + " euros son " + pesetas);
        }
    }
}
