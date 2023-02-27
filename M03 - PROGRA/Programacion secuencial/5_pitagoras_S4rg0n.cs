using System;

namespace pitagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que calcule la hipotenusa de un triángulo rectángulo. La longitud de los catetos se introducirá por teclado.*/

            Console.Write("Indícame el valor del primer cateto: ");
            double cat1 = double.Parse(Console.ReadLine());
            Console.Write("Indícame el valor del segundo cateto: ");
            double cat2 = double.Parse(Console.ReadLine());

            double hipo = Math.Sqrt((cat1 * cat1) + Math.Pow(cat2, 2));
            Console.WriteLine("La hipotenusa de tu triángulos con catetos de {0} y {1} respectivamente, es {2}.", cat1, cat2, hipo);
        }
    }
}
