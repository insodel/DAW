using System;

namespace ConsumoCoche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realiza un programa que calcule el coste del precio de la gasolina en un viaje. 
             El usuario introducirá los kilómetros a recorrer, el precio de la gasolina y el consumo
             del coche en litros por cada 100 kilómetros


            consumoCoche = 4L / 100Km
            kilometrosRecorridos = 140Km/100
            consumoViaje = consumoCoche * kilometrosRecorridos
            precioGasolina = 1,38€
            precioViaje = consumoViaje * precioGasolina
            */

            Console.WriteLine("Vamos a calcular el coste de gasolina del viaje");

            Console.WriteLine("Dime cuantos kilometros vas a recorrer");
            double kilometrosRecorridos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el precio de la gasolina");
            double precioGasolina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el consumo del coche");
            double consumoCoche = Convert.ToDouble(Console.ReadLine());

            double kilometrosPasados = kilometrosRecorridos / 100;
            double consumoViaje = consumoCoche * kilometrosPasados;
            double precioViaje = consumoViaje * precioGasolina;

            Console.WriteLine($"El viaje de {kilometrosRecorridos} kilometros te costara {precioViaje} euros");
        }
    }
}
