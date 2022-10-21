using System;

namespace Estructurada_29_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max, min;

            Console.WriteLine("Introduce un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Estos son los números impares introducidos entre estos 2 : ");

            if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = b;
                max = a;
            }

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
