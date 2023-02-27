using System;

namespace corona
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que calcule el área de una corona circular, los dos radios son introducidos por teclado.*/
            const double pi = Math.PI;

            Console.Write("Introduce un radio: ");
            double radio1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce un segundo radio: ");
            double radio2 = Double.Parse(Console.ReadLine());

            double area1 = radio1 * radio1 * pi;
            double area2 = pi * Math.Pow(radio2, 2);

            if (area1 < area2)
            {
                Console.WriteLine($"El área de la corona resultante es {area2 - area1}.");
            }
            else if (area2 < area1)
            {
                Console.WriteLine("El área de la corona resultante es {0}.", area1 - area2);
            } 
            else { Console.WriteLine("Ambas circunferencias tienen radio " + radio1 + ", no se genera una corona."); }
        }
    }
}
