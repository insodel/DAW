using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_conversor_moneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realiza un programa que calcule el valor de pesetas de una cantidad de
            euros.La cantidad de euros se entra por teclado.*/

            //Recoger valor en euros aportado. 
            Console.WriteLine("Introduce la cantidad en euros:");

                //Alerta el valor de la coma tiene que ser "," sinó no funciona correctamente.
                double a = double.Parse(Console.ReadLine());
                double b = a * 166.386;
                        
            //Imprime en la terminal el valor en euros y su conversion a pesetas.
            Console.WriteLine($"{a} euros son {b} pesetas.");

        }
    }
}
