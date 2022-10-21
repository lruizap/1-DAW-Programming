using System;

namespace Funciones_17_factorial_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("dime un número");
            n = int.Parse(Console.ReadLine());

            factorial(n);
        }

        static int factorial(int n)
        {
            int i, fact;
            i = 1;
            fact = 1;

            while (i <= n)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(n + " ! :");
            Console.WriteLine(fact);

            return fact;
        }
    }
}
