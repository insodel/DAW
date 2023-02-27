using System;

namespace TranformacionTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cree un programa que realiza la transformación de una cantidad de segundos en horas, minutos y segundos. 
             * La cantidad de segundos se introduce por teclado.*/

            //Pedimos el número de segundos:
            Console.WriteLine("Introduzca tiempo en segundos: ");
            int tiempo = Int32.Parse(Console.ReadLine());

            //Si dividimos por 3600 segundos que tiene cada hora y lo guardamos como 'int', tendremos cuantas horas completas hay. El resto de dicha división
            //nos dará los segundos restantes con los que calcular los minutos:
            int horas, segundos_restantes;
            horas = tiempo / 3600;
            segundos_restantes = tiempo % 3600;

            //Ahora podemos hacer lo mismo dividiendo segundos_restantes en grupos de 60 y el resto serán los segundos:
            int minutos = segundos_restantes / 60;
            int segundos = segundos_restantes % 60;

            //Mostramos resultado:
            Console.WriteLine("{0} segundos equivale a {1} horas, {2} minutos y {3}", tiempo, horas, minutos, segundos);

        }
    }
}
