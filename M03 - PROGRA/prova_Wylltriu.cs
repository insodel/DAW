using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static int Main(string[] args)
        {
            //Console.WriteLine(n);
            int price;
            int n;
            if (n < 5)
            {
                price = 100;
            }
            else if (n < 10)
            {
                price = 95;
            }
            else (n >= 10) {
                price = 90;
            }
            return n * price;
            //Console.WriteLine(n);
        }
    }
    }
}
