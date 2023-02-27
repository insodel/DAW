using System;

namespace viaje
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que calcule el coste del precio de la gasolina en un viaje. El usuario introducirá los kilómetros a recorrer, 
             * el precio de la gasolina y el consumo del coche en litros por cada 100 kilómetros.*/

            Console.Write("Cuántos km vas a recorrer?: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y cuánto consume tu coche cada 100km???: ");
            double consumo = double.Parse(Console.ReadLine());
            Console.Write("A qué precio está el litro de combustible?: ");
            float combustible = Convert.ToSingle(Console.ReadLine());

            float costeKm = (float)(consumo * combustible / 100); //Conversión explícita: al tipar costeKm como float (7 decimales) y teniendo consumo
                                                                  //como double (14 decimales), truncamos el resultado a float como se muestra en 
                                                                  //en esta línea.

            float costeViaje = (float)(costeKm * distancia); // De nuevo, costeViaje float, como distancia es double ==> Conversión explícita con (float)

            Console.WriteLine("Te va a costar el paseito de {0} km exactamente por {1} euros.", distancia, costeViaje);
        }
    }
}
