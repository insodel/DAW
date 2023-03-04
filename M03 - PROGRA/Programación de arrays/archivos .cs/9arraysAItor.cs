using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int mayorNum = 0;

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 50); // Generamos los valores aleatorios para cada posición del array
                Console.WriteLine(array[i]);// Se representa por pantalla para poder verificar que mayorNum toma el valor más alto
            }
                
            for (int i = 0; i < 10; i++)
            {
                if (i > mayorNum)
                {
                    mayorNum = array[i];
                    Console.WriteLine("El número más grande es " + mayorNum + ", y se encuentra en la posición " + (i+1));
                }
                else continue;
            }

        }
    }
}
