using System;

namespace pesetas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que calcule el valor de pesetas de una cantidad de euros. La cantidad de euros se entra por teclado.*/

            Console.Write("Introduce euros: ");
            double euros = double.Parse(Console.ReadLine());
            double pesetas = euros * 166;
            Console.Write($"{euros} euros son {pesetas} pesetas.\n");
        }
    }
}
