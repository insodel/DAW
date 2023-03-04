using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10; // Usamos n para definir el tamaño máximo de los arrays
            int[] arrayUno = new int[n] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; //valores añadidos para demostrar el correcto
            int[] arrayDos = new int[n] {2, 1, 2, 1, 2, 3, 4, 5, 2, 1}; //funcionamiento del algoritmo
            int[] arrayFinal = new int[n];

            for (int i = 0, j = 0; i < n; i++) //usamos i y j como índices de los arrays
            {
                arrayFinal[i] = arrayUno[i] + arrayDos[j];
                Console.WriteLine("La posición " + i + " del array uno tiene como valor " + arrayUno[i]);
                Console.WriteLine("La posición " + j + " del array dos tiene como valor " + arrayDos[j]);
                Console.WriteLine("La posición " + i + " del array final tiene como valor " + arrayFinal[i]);
            }

            Console.WriteLine("Tras las sumas, el array final es:");
            Console.WriteLine(arrayFinal);
        }
    }
}
