using System;

namespace _02_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, i;
            Console.WriteLine("Escribe el primer número");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el segundo número");
            n2 = int.Parse(Console.ReadLine());

            i = 1;

            if ((n % i == 0) && (n2 % i == 0))
            {
                i = n - 1;
                Console.WriteLine();
            }

        }
    }
}
