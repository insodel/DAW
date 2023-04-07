using System;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cantidad de euros:");
            int eurosOg = Convert.ToInt32(Console.ReadLine());
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5 };
            float[] monedas = { 2, 1, 0.5f, 0.2f, 0.1f, 0.05f, 0.02f, 0.01f };
            int numBilletes = 0;
            int resto;

            for (int i = 0; i < billetes.Length; i++)
            {
                numBilletes = eurosOg / billetes[i] ;
                Console.WriteLine(eurosOg + " son " + numBilletes + " billetes de " + billetes[i] + " euros.");
            }

            float numMonedas = 0;
            for (int i = 0; i < monedas.Length; i++)
            {
                numMonedas = (float)eurosOg / monedas[i];
                Console.WriteLine(eurosOg + " son " + numMonedas + " monedas de " + monedas[i] + " euros.");
            }
        }
    }
}
