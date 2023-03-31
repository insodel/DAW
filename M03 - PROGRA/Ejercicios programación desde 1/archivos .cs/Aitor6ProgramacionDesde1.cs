using System;

namespace Aitor6ProgramacionDesde1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cadena de carácteres: ");
            string frase = Console.ReadLine();
            int conteo = 0;
            // Utilizamos varios Replace para asegurarnos de que, a la hora de mirar si es palíndromo,
            // solo estaremos fijándonos en las letras (sin tildes, sin símbolos)
            // Para ello, esta solución 'a la fuerza bruta':
            frase = frase.Replace(" ", ""); 
            frase = frase.Replace(",", "");
            frase = frase.Replace(".", "");
            frase = frase.Replace("¿", "");
            frase = frase.Replace("?", "");
            frase = frase.Replace("¡", "");
            frase = frase.Replace("!", "");
            frase = frase.Replace("á", "a");
            frase = frase.Replace("é", "e");
            frase = frase.Replace("í", "i");
            frase = frase.Replace("ó", "o");
            frase = frase.Replace("ú", "u");
            frase = frase.ToLower();

            for (int i = 1; i < frase.Length; i++)
            {
                if (frase[i] == frase[frase.Length - (1+i)] )
                {
                    conteo++;
                }
                else continue;
            }
            if (conteo == (frase.Length - 1))
                Console.WriteLine("Es palíndromo.");
            else
                Console.WriteLine("No es palíndromo.");

        }
    }
}
