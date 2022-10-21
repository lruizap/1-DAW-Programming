using System;

namespace Estructurada_38_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, n2;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            n2 = int.Parse(Console.ReadLine());

            for (i = n; i >= 1; i--)
            {
                if (n % i == 0 && n2 % i == 0)
                {
                    Console.WriteLine("El resultado es : " + i);
                    i = 1;
                }
            }
        }
    }
}
