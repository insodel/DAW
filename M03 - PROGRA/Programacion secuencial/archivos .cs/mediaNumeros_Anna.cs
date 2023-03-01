using System;

namespace MediaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realiza un programa que calcule la media de tres números introducidos
             por teclado.
            */

            Console.WriteLine("Vamos a realizar la media de 3 números");

            Console.WriteLine("Dime un primer número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dime un segundo número");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dime un tercer núemero");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double media = ((numero1 + numero2 + numero3) / 3);

            Console.WriteLine("La media de los números es: " + media);
        }
    }
}
