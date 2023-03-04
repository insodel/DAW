using System;


namespace Ejercicio_Secuencial_8
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza una modificación al programa anterior. El consumo del coche será
    fijado por el programador a 5 litros a los 100 kilómetros.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de kilometros del viaje: ");
            float kmViaje = float.Parse(Console.ReadLine());
            //Aqui hemos especificado los kilometros totales que vamos a realizar en el viaje

            Console.WriteLine("Introduce el precio de la gasolina: ");
            float precioGas = float.Parse(Console.ReadLine());
            //Aqui ponemos el precio actual de la gasolina

            Console.WriteLine("El consumo del coche esta fijado en 5 litros a los 100 km.");
            int consumo = 5;

            float consumo100 = (float)consumo / 100;//Aqui lo que hacemos es una declaracion explicita a la variable "consumo" para convertirla en float.
            float precioFinal = consumo100 * kmViaje * precioGas;
            /*Aqui hacemos la division de consumo entre 100 para obtener cuanto vale exactamente 1km
            Una vez tenemos el precio de 1km, solo tenemos que multiplicarlo por kilometros totales del viaje y el precio del Gas
            Y obtenemos el precio final.*/

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine("El viaje de {0} km te saldrá por {1} euros.", kmViaje, precioFinal);
            Console.WriteLine($"El viaje de {kmViaje} km te saldrá por {precioFinal} euros.");
            Console.WriteLine("El viaje de " + kmViaje + " km te saldrá por " + precioFinal + " euros.");
        }
    }
}