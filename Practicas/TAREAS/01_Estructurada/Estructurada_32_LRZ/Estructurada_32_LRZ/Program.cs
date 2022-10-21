using System;

namespace Estructurada_32_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            max = n;

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Dime otro número");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }
            }

            Console.WriteLine("El máx es : " + max);
        }
    }
}
