using System;

namespace arraysAitor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in array)
            {
                Console.WriteLine("Posición "+ i +" del array, cuyo valor es "+(i+5));

            }

        }
    }
}