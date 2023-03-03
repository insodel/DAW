using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el número de kilómetros del viaje:");
            decimal kilometros = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("introduce el precio de la gasolina:");
            decimal gasolina = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el consumo del coche:");
            decimal consumo = Convert.ToDecimal(Console.ReadLine());

            decimal precio = (kilometros / 100) * (consumo * gasolina);

            Console.WriteLine($"El viaje de {kilometros} kilómetros te saldrá por {precio}");
        }
    }
}
