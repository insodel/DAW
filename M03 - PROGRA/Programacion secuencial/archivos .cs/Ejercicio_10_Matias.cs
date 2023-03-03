using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el número de segundos:");
            string entrada = Console.ReadLine();
            int segundos = int.Parse(entrada);

            int horas = segundos / 3600;
            segundos %= 3600;

            int minutos = segundos / 60;
            segundos %= 60;

            Console.WriteLine($"{entrada} segundos son {horas} horas, {minutos} minutos y {segundos} segundos.");
        }
    }
}
