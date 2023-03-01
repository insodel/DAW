using System;

namespace CoronaCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Realiza un programa que calcule el área de una corona circular, los dos
             radios son introducidos por teclado
            */

            Console.WriteLine("Vamos a calcular el área de una corona circular");

            // A = PI * (R2 - r2)

            Console.WriteLine("Introduce el radio del círculo pequeño");
            int radioPequeño = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce el radio del círculo grande");
            int radioGrande = int.Parse(Console.ReadLine());

            double area = Math.PI * ((Math.Pow(radioPequeño, 2)) - (Math.Pow(radioGrande, 2)));

            Console.WriteLine($"El área de la corona circular con radio {radioPequeño} y radio {radioGrande} es {area}");
        }
    }
}
