using System;

namespace consumoCoche2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realiza una modificación al programa anterior. El consumo del coche será
             fijado por el programador a 5 litros a los 100 kilómetros
            */

            Console.WriteLine("Vamos a calcular el coste del viaje si tu coche consumiera 5L/100Km");

            Console.WriteLine("Dime cuantos kilometros vas a recorrer");
            double kilometrosRecorridos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el precio de la gasolina");
            double precioGasolina = Convert.ToDouble(Console.ReadLine());

            double consumoCoche = 5;

            double kilometrosPasados = kilometrosRecorridos / 100;
            double consumoViaje = consumoCoche * kilometrosPasados;
            double precioViaje = consumoViaje * precioGasolina;

            Console.WriteLine($"El viaje de {kilometrosRecorridos} kilometros te costara {precioViaje} euros");
        }
    }
}
