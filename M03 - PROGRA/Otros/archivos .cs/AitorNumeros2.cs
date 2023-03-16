using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer operando:");
            int operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo operando:");
            int operando2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("SUMA: " + (operando1 + operando2));               
            Console.WriteLine("RESTA: " + (operando1 - operando2));                  
            Console.WriteLine("MULTIPLICACIÓN: " + (operando1 * operando2));                  
            Console.WriteLine("DIVISIÓN: " + (operando1 / operando2));                   
            Console.WriteLine("MÓDULO: " + (operando1 % operando2));
                   

        }
    }
}
