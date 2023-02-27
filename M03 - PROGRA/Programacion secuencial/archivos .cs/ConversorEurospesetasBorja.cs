using System;

namespace ejercicio_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de euros:");
            const euros = Convert.ToDouble(Console.ReadLine());
            double pesetas = euros * 166;
            Console.WriteLine("{0} euros son {1} pesetas",euros,pesetas);
            Console.WriteLine($"{euros} euros equivale a {pesetas} pesetas.");
           
        }
    }
}
