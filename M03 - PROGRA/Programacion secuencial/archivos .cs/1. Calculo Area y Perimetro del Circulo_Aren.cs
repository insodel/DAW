using System;


namespace Ejercicio_Secuencial_1
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que pida un número, y calcule el perímetro de la
    circunferencia y el área del círculo con ese radio. Ten en cuenta que el
    área de un círculo es a = PI * r * r, y el perímetro de la circunferencia es p
    = 2 * PI * r.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio de la circunferencia: ");

            double radio = double.Parse(Console.ReadLine());
            double PI = (Math.PI);
            double area = PI * radio * radio;
            double perim = 2 * PI * radio;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"El area de un circulo es {area} y el perimetro de la circunferencia es {perim}.");
            Console.WriteLine("El area de un circulo es {0} y el perimetro de la circunferencia es {1}.",area,perim);
            Console.WriteLine("El area de un circulo es " + area + " y el perimetro de la circunferencia es " + perim + ".");
        }
    }
}