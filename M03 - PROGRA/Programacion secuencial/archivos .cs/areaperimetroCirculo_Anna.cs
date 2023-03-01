using System;

namespace AreaPerimetroCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Realiza un programa que pida un número, y calcule el perímetro de la
            circunferencia y el área del círculo con ese radio. 
            
            Ten en cuenta que
            área de un círculo es a = PI * r * r, 
            y el perímetro de la circunferencia es 
            p = 2 * PI * r 
            */

            Console.WriteLine("Vamos a calcular el perímetro y el área de una circunferencia\nDime el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.Pow(radio, 2) * Math.PI;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"El área del círculo es {area} y el perímetro es {perimetro}");
        }
    }
}
