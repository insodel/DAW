using System;


namespace Ejercicio_Secuencial_4
{
    /*-----------------------------ENUNCIADO------------------------------*/
    /*
    Realiza un programa que calcule el área de un triángulo a partir de su
    base y su altura. El área de un triángulo es a = b * h / 2.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base del triangulo");
            float baseTriangulo = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura del triangulo");
            float alturaTriangulo = float.Parse(Console.ReadLine());
            
            float areaTriangulo = baseTriangulo * alturaTriangulo / 2;

            //PARA EL RESULTADO VOY A UTILIZAR LOS 3 METODOS DE CONCATENAR

            Console.WriteLine($"El area del triangulo es {areaTriangulo}.");
            Console.WriteLine("El area del triangulo es {0}.",areaTriangulo);
            Console.WriteLine("El area del triangulo es " + areaTriangulo + ".");
        }
    }
}