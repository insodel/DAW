using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Programa que permita ingresar un array de números enteros y devuelva el número más grande y el más pequeño. */
          
            Console.WriteLine("Introduce el tamaño del array:");
            int size = Convert.ToInt32(Console.ReadLine()); // Permite al usuario elegir el tamaño de arrayEnteros
            int[] arrayEnteros = new int[size];
        
            for (int i = 0; i < size; i++) // Utilizamos un for para rellenar el array
            {
                arrayEnteros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayorNum = 0;     // Inicializamos las dos variables necesarias para acabar el ejercicio
            int menorNum = 10000; 

            for (int i = 0; i < size; i++) // Bucle para sacar el número más grande del array
            {
                if (arrayEnteros[i] > mayorNum)
                {
                    mayorNum = arrayEnteros[i];
                }
                else continue;
            }
            for (int i = 0; i < size; i++) // Bucle para sacar el número más pequeño del array
            {
                if (arrayEnteros[i] < menorNum)
                {
                    menorNum = arrayEnteros[i];
                }
                else continue;
            }

            Console.WriteLine("El número más pequeño es {0} y el más grande es {1}", menorNum, mayorNum);
        }
    }
}
