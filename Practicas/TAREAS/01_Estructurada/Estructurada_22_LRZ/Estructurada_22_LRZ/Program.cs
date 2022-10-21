using System;

namespace Estructurada_22_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact, n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            i =  1;
            fact = 1;

            while (i <= n)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(n + " ! :");
            Console.WriteLine(fact);
        }
    }
}
