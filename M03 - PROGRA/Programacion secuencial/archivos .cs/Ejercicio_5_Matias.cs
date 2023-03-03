using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            double cateto1, cateto2, hipotenusa;

            Console.WriteLine("Introduce la longitud del primer cateto:");
            cateto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la longitud del segundo cateto:");
            cateto2 = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            Console.WriteLine("La hipotenusa del triángulo rectángulo es: " + hipotenusa);
        }
    }
}
