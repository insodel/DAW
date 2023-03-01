using System;

namespace HipotenusaTrianguloRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realiza un programa que calcule la hipotenusa de un triángulo rectángulo.
             La longitud de los catetos se introducirá por teclado. Utiliza el teorema de
             Pitágoras
            */

            Console.WriteLine("Vamos a calcular la hipotenusa de un triángulo rectángulo");

            // En un triángulo rectángulo, el cuadrado de la hipotenusa es igual a la suma de los cuadrados de los catetos
            // a y b catetos
            //c es la hipotenusa

            Console.WriteLine("Introduce el cateto a");
            int catetoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cateto b");
            int catetoB = int.Parse(Console.ReadLine());

            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) +  Math.Pow(catetoB, 2));

            Console.WriteLine($"La hipotenusa de un triángulo rectángulo con catetos {catetoA} y {catetoB} es {hipotenusa}");
        }
    }
}
