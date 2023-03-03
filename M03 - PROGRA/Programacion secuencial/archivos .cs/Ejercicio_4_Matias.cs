using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca la base del triángulo ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la altura del triángulo");
            int num2 = int.Parse(Console.ReadLine());

            int area = (num1 * num2) / 2;
            Console.WriteLine("La altura es {0}", area);
        }
    }
}
