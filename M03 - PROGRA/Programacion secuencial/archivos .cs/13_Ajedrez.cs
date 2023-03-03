using System;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Supongamos que tenemos un tablero de ajedrez con las casillas numeradas de la 1 a la 64 en el orden de izquierda a derecha y de arriba abajo. 
             * Realiza un programa que calcula la fila y la columna en la que se encuentra una casilla introducida por el usuario.*/

            //Creamos el tablero mediante un array bidimensional:
            int[,] tablero = new int[8, 8] { { 1, 2, 3, 4, 5, 6, 7, 8 }, { 9, 10, 11, 12, 13, 14, 15, 16 }, { 17, 18, 19, 20, 21, 22, 23, 24 }, { 25, 26, 27, 28, 29, 30, 31, 32 }, { 33, 34, 35, 36, 37, 38, 39, 40 }, { 41, 42, 43, 44, 45, 46, 47, 48 }, { 49, 50, 51, 52, 53, 54, 55, 56 }, { 57, 58, 59, 60, 61, 62, 63, 64 } };

            //Pedimos entrada de datos acotada al número de casillas de nuestro tablero.
            int numero;
            do
            {
                Console.Write("Introduzca un número entre 1 y 64 incluidos: ");
                numero = Int32.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 64);

            for (int i = 0; i < tablero.GetLength(0); i++) {
                for (int j = 0; j < tablero.GetLength(0) ; j++)
                {
                    //int linea = i;
                    //Console.Write(linea);
                if (tablero[i, j] == numero)
                {
                    int fila, columna;
                    fila = ++i;
                    columna = ++j;
                    Console.WriteLine($"El número {numero} se encuentra en la fila {fila} y la columna {columna}");
                    break;
                }
                else continue;
                }            
            }            
            
        }
    }
}
