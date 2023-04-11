using System;

namespace Ejercicio_13 /* Supongamos que tenemos un tablero de ajedrez con las casillas numeradas de la 1 a la 64 en el orden de izquierda a derecha y de arriba abajo.
                          Realiza un programa que calcula la fila y la columna en la que se encuentra una casilla introducida por el usuario.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[64];

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Introduce la casilla (entre 1 y 64) para saber su localización: ");
            int casilla = int.Parse(Console.ReadLine());
            int columna = 0;
            int fila = 0;
            if (casilla % 8 == 0)
            {
                columna = 8;
                fila = casilla / 8;
            }
            else
            {
                columna = casilla % 8;
                fila = (casilla / 8) + 1;
            }
            Console.WriteLine("La casilla {0} está en la fila {1} y columna {2}", casilla, fila, columna);
        }
    }
}