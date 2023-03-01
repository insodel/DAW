using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija un número de elementos para el array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Elija un número para rellenar los arrays:");
            int multiplo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < size; i++) //Hacemos un bucle con un nº de iteraciones máximo dependiente del tamaño del array
            {
                array[i] = i * multiplo;
                Console.WriteLine("La posición "+i+" del array tiene un valor "+array[i]);
            }
        }
    }
}
