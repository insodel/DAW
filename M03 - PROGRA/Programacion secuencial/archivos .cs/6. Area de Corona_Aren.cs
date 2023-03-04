using System;


namespace Ejercicio_Secuencial_6
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule el área de una corona circular, los dos
    radios son introducidos por teclado.
    */
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio mayor: ");
            double radioMayor = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el radio menor: ");
            double radioMenor = double.Parse(Console.ReadLine());

            double radioMayorCuadrado = radioMayor * radioMayor;
            double radioMenorCuadrado = radioMenor * radioMenor;
            double area = Math.PI * (radioMayorCuadrado - radioMenorCuadrado);

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"El área de la corona es {area}.");
            Console.WriteLine("El área de la corona es {0}.",area);
            Console.WriteLine("El área de la corona es " + area + ".");
        }
    }
}