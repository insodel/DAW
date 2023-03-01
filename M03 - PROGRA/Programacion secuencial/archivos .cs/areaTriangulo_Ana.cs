using System;

namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Realiza un programa que calcule el área de un triángulo a partir de su
             base y su altura. El área de un triángulo es a = b * h / 2
            */

            Console.WriteLine("Vamos a convertir a calcular el área de un triángulo");

            Console.WriteLine("Dime cuanto mide su base");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dime cuanto mide su altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = ((baseTriangulo * altura) / 2);

            Console.WriteLine($"El área del triángulo es {area}");
        }
    }
}
