using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca el radio");
            const double Pi = 3.1416;
            int radio = int.Parse(Console.ReadLine());
            double area = (Pi * radio * radio);
            double perimtero = (2 * Pi * radio);

            Console.WriteLine($"El área del círculo es {area}  y el perímetro de la circunferencia es {perimtero} ");
            //otra opción sería
            //Console.WriteLine("El área del círculo es {0}  y el perímetro de la circunferencia es {1} ", area, perimtero);
        }
    }
}
