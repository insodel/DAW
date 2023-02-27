using System;

namespace area_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base del triángulo:");
            int baseT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la áltura del triángulo");
            int altura = Convert.ToInt32(Console.ReadLine());
            int area = (baseT * altura) / 2;
            Console.WriteLine("El área del triángulo es " + area);
        }
    }
}
