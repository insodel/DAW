using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //la clase Random nos permitirá generar números aleatorios para rellenar nuestro array
            int[] array = new int[100];
            int apariciones = 0; //variable que contendrá el número de veces que aparece el número target en el array

            for (int i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0,50); // los números generados aleatorios estarán en el rango 0-50 
            }

            Console.WriteLine("Indique un número para realizar la búsqueda:");
            int target = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                if (target == array[i])
                {
                    apariciones = apariciones + 1; //cada vez que se encuentre target, se sumará uno a la cuenta de apariciones
                    Console.WriteLine("El número " + target + " se ha encontrado en la posición " + i + ", esta es la aparición número " + apariciones + " de dicho valor.");
                }
                else continue;
            }
        }
    }
}
