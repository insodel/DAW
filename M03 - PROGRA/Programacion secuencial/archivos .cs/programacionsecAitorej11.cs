using System;

namespace secuencialAitor11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de veces que han indicado SI:");
            int si = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el número de veces que han indicado NO:");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el número de veces que han indicado NO SABE/NO CONTESTA:");
            int nsnc = Convert.ToInt32(Console.ReadLine());
            int totalVotos = si + no + nsnc; //para poder tener la referencia de 'cuanto es el 100%', sumamos todos los votos
            double porcentajeSi = ((double)si / (double)totalVotos) * 100; //usamos double por obtener el output más parecido al de las imagenes
            double porcentajeNo = ((double)no / (double)totalVotos) * 100; //repetimos para NO y NSNC
            double porcentajeNsnc = ((double)nsnc / (double)totalVotos) * 100;
            /* Y ya solo quedará mostrar el output */
            Console.WriteLine("Resultado SI: " + porcentajeSi + @"%");
            Console.WriteLine("Resultado NO: " + porcentajeNo + @"%");
        }
    }
}