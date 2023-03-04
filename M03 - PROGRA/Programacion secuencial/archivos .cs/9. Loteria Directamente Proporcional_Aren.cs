using System;


namespace Ejercicio_Secuencial_9
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Tres amigos compran billetes de lotería y acuerdan repartir los posibles
    premios proporcionalmente a lo que ha aportado cada uno. Realiza un
    programa que permita introducir por teclado las cantidades aportadas por
    cada uno y el premio obtenido. El programa mostrará cuanto le
    corresponde a cada uno.
    */

    class Program
    {
        static void Main(string[] args)
        {
            /*OPERACION DE REPARTO DIRECTAMENTE PROPORCIONAL*/

            Console.WriteLine("Introduce el nombre del primer participante.");
            string nombre1 = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad que ha aportado {0}",nombre1);
            float cantidad1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre del segundo participante.");
            string nombre2 = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad que ha aportado {0}", nombre2);
            float cantidad2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre del tercer participante.");
            string nombre3 = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad que ha aportado{0}", nombre3);
            float cantidad3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad del premio: ");
            float premioTotal = float.Parse(Console.ReadLine());

            float cantidadTotalAportada = cantidad1 + cantidad2 + cantidad3;
            float premio1 = premioTotal * cantidad1 / cantidadTotalAportada;
            float premio2 = premioTotal * cantidad2 / cantidadTotalAportada;
            float premio3 = premioTotal * cantidad3 / cantidadTotalAportada;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"La cantidad aportada por {nombre1} es de {cantidad1} EUROS y se lleva un total de {premio1} EUROS.");
            Console.WriteLine($"La cantidad aportada por {nombre2} es de {cantidad2} EUROS y se lleva un total de {premio2} EUROS.");
            Console.WriteLine($"La cantidad aportada por {nombre3} es de {cantidad3} EUROS y se lleva un total de {premio3} EUROS.");
        }
    }
}