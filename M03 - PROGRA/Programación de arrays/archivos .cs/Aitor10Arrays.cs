using System;

namespace Ordenar_sin_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int[] arrayOrdenado = new int[10];
            int n = array.Length;
            int mayorNum;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 40);
                arrayOrdenado[i] = array[i];
            }             

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (arrayOrdenado[i] <arrayOrdenado[j])
                    {
                        mayorNum = arrayOrdenado[j];
                        arrayOrdenado[j] = arrayOrdenado[i];
                        arrayOrdenado[i] = mayorNum;
                    }
                }
            }
            foreach (var num in array)
                Console.Write(" " + num + " ");
            Console.WriteLine("\n");
            foreach (var num in arrayOrdenado)
                Console.Write(" " + num + " ");
        }
    }
}
