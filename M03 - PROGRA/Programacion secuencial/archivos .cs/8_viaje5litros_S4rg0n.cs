using System;

namespace viaje5litros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza una modificación al programa anterior. El consumo del coche será fijado por el programador a 5 litros a los 100 kilómetros.*/

            const int consumo = 5;
            Console.Write("Cuántos km vas a recorrer?: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
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