using System;

namespace Estructurada_20_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, n, i;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            max = n;

            i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Dime otro número");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }

                i++;
            }

            Console.WriteLine(max);

        }
    }
}
