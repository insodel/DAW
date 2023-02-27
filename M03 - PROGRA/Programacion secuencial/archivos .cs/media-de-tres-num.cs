using System;

namespace calculo_de_pesetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de euros:");
            double euros = Convert.ToDouble(Console.ReadLine());
            double pesetas = euros * (double)166.3860;
            Console.WriteLine(euros + " euros son " + pesetas);
        }
    }
}
