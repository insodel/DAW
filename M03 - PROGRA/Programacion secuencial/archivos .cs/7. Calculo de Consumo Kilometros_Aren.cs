using System;


namespace Ejercicio_Secuencial_7
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule el coste del precio de la gasolina en un
    viaje. El usuario introducirá los kilómetros a recorrer, el precio de la
    gasolina y el consumo del coche en litros por cada 100 kilómetros.
    */
    class Program //Nombre de nuestra clase.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de kilometros del viaje: ");
            float kmViaje = float.Parse(Console.ReadLine());
            //Aqui hemos especificado los kilometros totales que vamos a realizar en el viaje

            Console.WriteLine("Introduce el precio de la gasolina: ");
            float precioGas = float.Parse(Console.ReadLine());
            //Aqui ponemos el precio actual de la gasolina

            Console.WriteLine("Introduce el consumo del coche: ");
            float consumo = float.Parse(Console.ReadLine());

            float consumo100 = consumo / 100;
            float precioFinal = consumo100 * kmViaje * precioGas;
            /*Aqui hacemos la division de consumo entre 100 para obtener cuanto vale exactamente 1km
            Una vez tenemos el precio de 1km, solo tenemos que multiplicarlo por kilometros totales del viaje y el precio del Gas
            Y obtenemos el precio final.*/

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine("El viaje de {0} km te saldrá por {1} euros.",kmViaje,precioFinal);
            Console.WriteLine($"El viaje de {kmViaje} km te saldrá por {precioFinal} euros.");
            Console.WriteLine("El viaje de " + kmViaje + " km te saldrá por " + precioFinal + " euros.");
        }
    }
}