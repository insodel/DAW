using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que pida un número, y calcule el perímetro de la circunferencia y el área del 
             * círculo con ese radio. Ten en cuenta que el área de un círculo es a = PI * r * r, y el perímetro
             * de la circunferencia es p = 2 * PI * r.*/

            //Inicializamos constante PI:
            const double pi = 3.1416;

            //Solicitud de entrada de datos y asignación a variable:
            double radio;
            Console.Write("Por favor introduzca radio: ");
            radio = Double.Parse(Console.ReadLine());

            //Calculamos y mostramos en pantalla:
            double area = radio * radio * pi;
            double perimetro = radio * pi * 2;

            Console.WriteLine("Tu círculo tiene un área de " + area +" y un perímetro de " + perimetro + ".");
        }
    }
}
