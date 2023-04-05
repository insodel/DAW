using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine("El área del círculo es " + area + " y el perímetro es " + perimetro);
        }
    }
}
