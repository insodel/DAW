using System;

namespace ConsoleApp1
{
    class consoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca la cantidad que ha aportado Juan");
            double aporte_juan = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad que ha aportado Marta");
            double aporte_marta = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la cantida dque ha aportado Marcos");
            double aporte_marcos = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad del premio");
            double premio = double.Parse(Console.ReadLine());

            //cálculo del aporte total
            double total_aportes = aporte_juan + aporte_marta + aporte_marcos;

            double prop1 = aporte_juan / total_aportes;
            double prop2 = aporte_marta / total_aportes;
            double prop3 = aporte_marcos / total_aportes;

            //cálculo del premio
            double premio_juan = premio * prop1;
            double premio_marta = premio * prop2;
            double premio_marcos = premio * prop3;

            Console.WriteLine($"Juan ha aportado {aporte_juan} y se lleva {premio_juan}");

            Console.WriteLine($"Marta ha aportado{aporte_marta} y se lleva{premio_marta}");

            Console.WriteLine($"Marcos ha aportado {aporte_marcos} y se lleva {aporte_marcos}");
        }
    }
}
