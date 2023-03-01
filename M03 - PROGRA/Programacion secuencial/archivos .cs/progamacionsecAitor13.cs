using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableroAjedrez = new int[,] { {1, 2, 3, 4, 5, 6, 7, 8}, {9, 10, 11, 12, 13, 14, 15, 16}, {17, 18, 19, 20, 21, 22, 23, 24,}, { 25, 26, 27, 28, 29, 30, 31, 32}, {33, 34, 35, 36, 37, 38, 39, 40}, {41, 42, 43, 44, 45, 46, 47, 48}, {49, 50, 51, 52, 53, 54, 55, 56}, {57, 58,59, 60, 61, 62, 63, 64} };
            Console.WriteLine("Introduce la casilla (entre 1 y 64):");
            int casillaUsuario = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tableroAjedrez.GetLength(0); i++)  //Primer for loop para las filas
            {
                for (int j = 0; j < tableroAjedrez.GetLength(0); j++) //Segundo loop (nested) para las columnas
                {
                    if (casillaUsuario == tableroAjedrez[i, j])
                    {
                        Console.WriteLine("La posición de la casilla " + casillaUsuario + " es fila " + (i+1) + ", columna " + (j+1));
                    }
                    else continue;
                }
            }
        }
    }
}
