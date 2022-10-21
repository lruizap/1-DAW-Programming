using System;

namespace Estructurada_39_LRZ
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

            i = 1;
            while ((i % n != 0) || (i % n2 != 0))
            {
                {
                    i++;
                }
            }

            Console.WriteLine("El minimo común múltiplo es " + i);

        }
    }
}
