using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6; // 6 como tamaño máximo para poder usar después 1 como índice y que se muestren 5 resultados
            Random rnd = new Random();
            int[] array = new int[n];
            int[] arrayInvert = new int[n];

            for (int i = 1; i < n; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.WriteLine("Elemento número " + i + " con valor " + array[i]);
            }

            for (int j = 1; j < n; j++)
            {
                arrayInvert[j] = array[n-j];
                Console.WriteLine("Elemento invertido " + j + " con valor " + arrayInvert[j]);
            }
            
        }
    }
}
