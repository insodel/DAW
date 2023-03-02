using System;

namespace arrays3Aitor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 100;
                        
            int[] arrayLongitud = new int[size]; //Array con la longitud de las cadenas del otro array
            string[] arrayNombres = new string[size]; //Array que almacena los nombres

            for (int i = 0; i<size; i++)
            {
                Console.WriteLine("Introduzca un nombre:");
                arrayNombres[i] = Console.ReadLine();
                arrayLongitud[i] = arrayNombres[i].Length;
                Console.WriteLine("La longitud de "+arrayNombres[i]+" es de "+arrayLongitud[i]);
            }


        }
    }
}
