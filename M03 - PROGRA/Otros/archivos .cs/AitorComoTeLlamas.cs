using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas?");
            string name = Console.ReadLine();
            // A continuación tres posibles formas de conseguir el mismo resultado.
            Console.WriteLine("¡Hola, {0}!", name);
            Console.WriteLine("¡Hola, " + name + "!");
            Console.WriteLine($"¡Hola, {name}!");
        }
    }
}
