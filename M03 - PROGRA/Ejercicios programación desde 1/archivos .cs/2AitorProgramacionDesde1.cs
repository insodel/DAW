using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Programa que pida al usuario un número entero positivo y que calcule la suma de los números pares e impares desde 1 hasta ese
            número utilizando bucles. */

            Console.WriteLine("Introduzca un número entero positivo (superior a 0): ");
            int numEntero = Convert.ToInt32(Console.ReadLine());
            int sumaPares = 0, sumaImpares = 0;

            for (int i = 0; i <= numEntero; i++) // Nuestra interpretación del enunciado es que tenemos que sumar también el número entero introducido por el usuario
            {                                    // Podríamos modificar la salida del for a (i < numEntero) si NO quisiéramos sumar el número entero elegido por el usuario.
                if (i % 2 == 0)
                {
                    sumaPares += i;
                }
                else
                    sumaImpares += i;
            }
            Console.WriteLine("La suma de los números pares desde 0 hasta {0} es {1}.",numEntero, sumaPares);
            Console.WriteLine("La suma de los números impares desde 0 hasta {0} es {1}.", numEntero, sumaImpares);
        }
    }
}
