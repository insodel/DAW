using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el radio mayor;");
            double radio_mayor = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el radio menor;");
            double radio_menor = Double.Parse(Console.ReadLine());

            const double pi = Math.PI;

            double area = pi * (Math.Pow(radio_mayor, 2) - Math.Pow(radio_menor, 2));

            Console.WriteLine($"El área de la corona circular es: {area}");
        }
    }
}
