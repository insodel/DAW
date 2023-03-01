using System;

namespace EjerciciosProgramacionA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Realiza un programa que calcule el valor de pesetas de una cantidad de
             euros. La cantidad de euros se entra por teclado.
            */

            Console.WriteLine("Vamos a convertir euros a pesetas \nIntroduce la cantidad de euros");

            // 1€ = 166,3860 pesetas

            double euros = Convert.ToDouble(Console.ReadLine());
            double pesetas = euros * 166.3860;

            Console.WriteLine($"{euros} son {pesetas} pesetas");
        }
    }
}
