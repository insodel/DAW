using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el primer número;");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número");
            int num3 = int.Parse(Console.ReadLine());

            int media = (num1 + num2 + num3) / 3;



            Console.WriteLine($"La media de los números {num1} {num2} y {num3}  es {media} ");
        }
    }
}
