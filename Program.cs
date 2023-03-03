using System;

namespace Tablas_de_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un numero del 1 al 9 para ver la tabla de multiplicar correspondiente");

            int factor = 0, result;

            int n = int.Parse(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine("\nLa tabla de multiplicar del {0} es:\n", n);

                while (factor < 11)
                {
                    result = n * factor;
                    Console.WriteLine(n + " X " + factor + " = " + result);
                    factor++;
                }
            }
            else Console.WriteLine("El numero a multiplicar debe ser menos a 10!");


        }
    }
}
