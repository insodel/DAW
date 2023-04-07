using System;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor de n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 21);
            }

            int conteoAprobados = 0;
            int conteoSuspensos = 0;
            int promedioApro = 0;
            int promedioSusp = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 10)
                {
                    conteoAprobados++;
                    promedioApro += array[i];
                }
                else
                {
                    conteoSuspensos++;
                    promedioSusp += array[i];
                }
            }
            promedioSusp /= conteoSuspensos;
            promedioApro /= conteoAprobados;

            Console.WriteLine(conteoAprobados + " alumnos han aprobado. La media de sus notas es de " + promedioApro + " puntos.");
            Console.WriteLine(conteoSuspensos + " alumnos han suspendido. La media de sus notas es de " + promedioSusp + " puntos.");
        }
    }
}
