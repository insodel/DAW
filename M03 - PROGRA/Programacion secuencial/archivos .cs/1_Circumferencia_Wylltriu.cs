using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Ampliación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio:");
            const double PI = 3.1415926535897931;
            string r = Console.ReadLine();
            double a = int.Parse(r) * int.Parse(r) * PI;
            double b = 2 * PI * int.Parse(r);
            Console.WriteLine("El área del círculo es:" + a + ", y el perímetro de la circumferencia es " + b);


        }
    }
}
