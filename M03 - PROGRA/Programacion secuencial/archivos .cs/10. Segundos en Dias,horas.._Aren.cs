using System;


namespace Ejercicio_Secuencial_10
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Cree un programa que realiza la transformación de una cantidad de
    segundos en dias, horas, minutos y segundos. La cantidad de segundos se
    introduce por teclado.
    */

    class Program
    {
        static void Main(string[] args)
        {
        //CALCULAR CUANTOS DIAS, HORAS, MINUTOS Y SEGUNDOS SON "X" SEGUNDOS

            Console.WriteLine("Introduce el número de segundos: ");

            int segTotales = int.Parse(Console.ReadLine());
            int dias = segTotales / 86400;
            int restoHoras = segTotales % 86400;
            int horas = restoHoras / 3600;
            int restoMin = restoHoras % 3600;
            int minutos = restoMin / 60;
            int segundos = restoMin % 60;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"Has introducido {segTotales} segundos, que equivalen a {dias} dias, {horas} horas, {minutos} minutos y {segundos} segundos.");
            Console.WriteLine("Has introducido {0} segundos, que equivalen a {1} dias, {2} horas, {3} minutos y {4} segundos.", segTotales, dias, horas, minutos, segundos);
            Console.WriteLine("Has introducido "+segTotales+" segundos, que equivalen a "+dias+" dias, "+horas+" horas, "+minutos+" minutos y "+segundos+" segundos.");
        }
    }
}