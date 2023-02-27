using System;

namespace aPachas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tres amigos compran billetes de lotería y acuerdan repartir los posibles premios proporcionalmente a lo que ha aportado cada uno. 
             * Realiza un programa que permita introducir por teclado las cantidades aportadas por cada uno y el premio obtenido. El programa 
             * mostrará cuanto le corresponde a cada uno.*/


            //Petición de entrada de datos e inicialización de variables:

            Console.Write("Cuanto dinero ha puesto Juan?: ");
            float primero = Convert.ToSingle(Console.ReadLine());
            Console.Write("Y Marta?: ");
            float segundo = Single.Parse(Console.ReadLine());
            Console.Write("Con cuánto ha contribuido Marcos?: ");
            float tercero = Convert.ToSingle(Console.ReadLine());
            Console.Write("De cuánto ha sido el premio?: ");
            int premio = Convert.ToInt32(Console.ReadLine());

            //Calculamos qué porcentaje le corresponde a cada 1:
            float total_partes = primero + segundo + tercero;
            float parte_primero = primero / total_partes * 100;
            float parte_segundo = segundo / total_partes * 100;
            float parte_tercero = tercero / total_partes * 100;

            //Mostramos resultados multiplicando los porcentajes por el premio total:
            Console.WriteLine("Juan ha aportado {0} euros, un {1}% del total, así que se lleva {2} euros", primero, parte_primero, parte_primero * premio / 100);
            Console.WriteLine($"Marta se lleva {parte_segundo * premio / 100} euros, por haber contribuido en un {parte_segundo}% con sus {segundo} euros");
            Console.WriteLine("A Marcos le quedan " + parte_tercero * premio / 100 + " euros por sus " + tercero + " euros que hacían un " + parte_tercero + "% de aportación.");

        }
    }
}
