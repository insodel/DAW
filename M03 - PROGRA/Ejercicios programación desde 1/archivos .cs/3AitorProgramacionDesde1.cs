using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Programa que reciba dos arrays de números enteros de igual longitud y los multiplique elemento por elemento, guardando el resultado 
                 en un tercer array. Luego, muestra el tercer array en pantalla. */

            Console.WriteLine("Determine el tamaño del array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arrayUno = new int[size];
            int[] arrayDos = new int[size];
            int[] arrayMultiplicado = new int[size];

            for (int i = 0; i < size; i++)
            {
                arrayUno[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                arrayDos[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < size; i++)
            {
                arrayMultiplicado[i] = arrayUno[i] * arrayDos[i];
                Console.WriteLine("La multiplicación de {0} y {1} es {2}.", arrayUno[i], arrayDos[i], arrayMultiplicado[i]);
            }

            // Otro método de visualización del resultado
            Console.WriteLine("Los valores del array multiplicado son: ");
            foreach (int numero in arrayMultiplicado)
            {
                Console.Write(numero + " ");
            }
            
        }
    }
}
