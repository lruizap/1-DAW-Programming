using System;

namespace Estructurada_14_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, contador;
            Console.WriteLine("Dime el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo número");
            n2 = int.Parse(Console.ReadLine());
            contador = n1;

            while (n1 > n2)
            {
                Console.WriteLine("Introduce 2 números válidos");
                Console.WriteLine("Dime el primer número");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dime el segundo número");
                n2 = int.Parse(Console.ReadLine());
            }

            n1 = n1 + 1;
            if (n2 > n1)
            {
                Console.WriteLine("Los números comprendidos entre el primero y el segundo son :");
                while (n1<n2)
                {
                    Console.WriteLine(n1);
                    n1++;
                }
            }
        }
    }
}
