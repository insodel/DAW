using System;

namespace afadfaf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer operando:");
            int operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo operando:");
            int operando2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Que operación desea realizar? Pulse 1 para suma, 2 para resta, 3 para multiplicación, 4 para división, 5 para módulo:");
            int operacion = Convert.ToInt32(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("SUMA: " + (operando1 + operando2));
                    break;

                case 2:
                    Console.WriteLine("RESTA: " + (operando1 - operando2));
                    break;

                case 3:
                    Console.WriteLine("MULTIPLICACIÓN: " + (operando1 * operando2));
                    break;

                case 4:
                    Console.WriteLine("DIVISIÓN: " + (operando1 / operando2));
                    break;

                case 5:
                    Console.WriteLine("MÓDULO: " + (operando1 % operando2));
                    break;
            }
        }
    }
}