using System;


namespace Ejercicio_Secuencial_5
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule la hipotenusa de un triángulo rectángulo.
    La longitud de los catetos se introducirá por teclado. Utiliza el teorema de Pitágoras.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer cateto: ");
            double cateto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo cateto: ");
            double cateto2 = double.Parse(Console.ReadLine());

            double cateto1Cuadrado = cateto1 * cateto1;
            double cateto2Cuadrado = cateto2 * cateto2;
            double hipoCuadrado = cateto1Cuadrado + cateto2Cuadrado;
            double hipo = Math.Sqrt(hipoCuadrado);

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"La hipotenusa de un rectángulo con catetos {cateto1} y {cateto2} es {hipo}.");
            Console.WriteLine("La hipotenusa de un rectángulo con catetos {0} y {1} es {2}",cateto1,cateto2,hipo);
            Console.WriteLine("La hipotenusa de un rectángulo con catetos " + cateto1 + " y " + cateto2 + " es " + hipo + ".");

        }
    }
}