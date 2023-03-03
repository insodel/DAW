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

            const decimal consumo = 5;

            decimal precio = (kilometros / 100) * (consumo * gasolina);

            Console.WriteLine($"El viaje de {kilometros} kilómetros te saldrá por {precio}");
        }
    }
}
