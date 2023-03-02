using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_de_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realiza un programa que calcule la media 
             de tres números introducidos por teclado.*/

            //Declaramos y asignamos el valor de las tres variables.
            Console.WriteLine("Introduce el primer número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            int c = int.Parse(Console.ReadLine());

            //Hacemos el cálculo de la media y lo mostramos en el terminal.
            int d = (a + b + c) / 3;
            Console.WriteLine("La media de los valores" + a + b + c + "es: " + d);

        }
    }
}
