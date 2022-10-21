using System;

namespace Estructurada_34_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact, n;

            Console.WriteLine("Escribe el número del que quieres el factorial");
            n = int.Parse(Console.ReadLine());
            fact = 1;

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(n+"! :" );
            Console.WriteLine(fact);


        }
    }
}
