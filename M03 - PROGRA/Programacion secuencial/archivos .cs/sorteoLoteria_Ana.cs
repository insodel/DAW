using System;

namespace sorteoLoteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Tres amigos compran billetes de lotería y acuerdan repartir los posibles
             premios proporcionalmente a lo que ha aportado cada uno. Realiza un
             programa que permita introducir por teclado las cantidades aportadas por
             cada uno y el premio obtenido. El programa mostrará cuanto le
             corresponde a cada uno
            */

            Console.WriteLine("Vamos a repartir la loteria");

            Console.WriteLine("Introduce la cantidad que ha aportado la primera persona");
            double aportado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad que ha aportado la segunda persona");
            double aportado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad que ha aportado la tercera persona");
            double aportado3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad del premio");
            double premio = Convert.ToDouble(Console.ReadLine());

            double sumaAportado = aportado1 + aportado2 + aportado3;
            double parteProporcional1 = (premio * aportado1) /sumaAportado;
            double parteProporcional2 = (premio * aportado2) / sumaAportado;
            double parteProporcional3 = (premio * aportado3) / sumaAportado;

            Console.WriteLine($"La primera persona ha aportado {aportado1} y ha ganado {parteProporcional1}");
            Console.WriteLine($"La primera persona ha aportado {aportado2} y ha ganado {parteProporcional2}");
            Console.WriteLine($"La primera persona ha aportado {aportado3} y ha ganado {parteProporcional3}");

        }
    }
}
