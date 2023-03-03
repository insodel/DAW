using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            const double pesetas = 166.386;

            Console.WriteLine("Conversor de Euros a pesetas");
            Console.WriteLine("Introduce la cantidad de Euros");

            double cantidad = double.Parse(Console.ReadLine());

            double resultado = (cantidad * pesetas);

            Console.WriteLine("La cantidad de pesetas que obtendrías sería " + resultado);
        }
    }
}
