using System;


namespace Ejercicio_Secuencial_2
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule la media de tres números introducidos
    por teclado.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer numero:");
            int num3 = int.Parse(Console.ReadLine());

            int resultado = (num1 + num2 + num3) / 3;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"La media de los números {num1}, {num2}, {num3} es {resultado}.");
            Console.WriteLine("La media de los numero {0}, {1}, {2} es {3}.",num1,num2,num3,resultado);
            Console.WriteLine("La media de los números " + num1 + ", " + num2 + ", "+num3 + " es " + resultado + ".");
        }
    }
}