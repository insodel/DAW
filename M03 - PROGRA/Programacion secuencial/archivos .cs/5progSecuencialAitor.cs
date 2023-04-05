using System;

namespace ConsoleApp70
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor del primer cateto:\n");
            double primerCateto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el valor del primer cateto:\n");
            double segundoCateto = Convert.ToInt32(Console.ReadLine());

            double hipotenusaCuadrado = (primerCateto * primerCateto) + (segundoCateto * segundoCateto);
            double hipotenusa = Math.Sqrt(hipotenusaCuadrado);

            Console.WriteLine("La longitud de la hipotenusa es de " + hipotenusa);



        }
    }
}
