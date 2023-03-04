using System;


namespace Ejercicio_Secuencial_3
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule el valor de pesetas de una cantidad de
    euros. La cantidad de euros se entra por teclado.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad de euros que quieres convertir a pesetas");
            
            float euros = float.Parse(Console.ReadLine());

            float resultado = euros * 166;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"{euros} euros son {resultado} pesetas.");
            Console.WriteLine("{0} euros son {1} pesetas.", euros, resultado);
            Console.WriteLine(euros + " euros son "+ resultado + " pesetas.");
        }
    }
}