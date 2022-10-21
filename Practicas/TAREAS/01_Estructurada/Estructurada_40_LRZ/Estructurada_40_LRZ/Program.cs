using System;

namespace Estructurada_40_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            i = 0;

            for (i = 2; i < n; i++)
            {
                if (n % i == 1)
                {
                    Console.WriteLine("Es primo");
                    i++;
                }
                else
                {
                    Console.WriteLine("No es primo");
                    i++;
                }
            }
        }
    }
}
