using System;

namespace segundosHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Cree un programa que realiza la transformación de una cantidad de
             segundos en horas, minutos y segundos. La cantidad de segundos se
             introduce por teclado
             */

            Console.WriteLine("Vamos a transformar los segundos en horas, minutos y segundos");

            Console.WriteLine("Introduce la cantidad de segundos");
            int segundosIntroducidos = Int32.Parse(Console.ReadLine());

            int horas = segundosIntroducidos / 3600;
            int minutos = (segundosIntroducidos - horas * 3600) / 60;
            int segundos = segundosIntroducidos - (horas * 3600 + minutos * 60);

            Console.WriteLine($"{segundosIntroducidos} son {horas} horas, {minutos} minutos y {segundos} segundos");
        }
    }
}
