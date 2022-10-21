using System;

namespace Funciones_04_ValoresEntreAmbos_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;
            Console.WriteLine("Dime el primer número");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número");
            n2 = int.Parse(Console.ReadLine());

            ImprimeSerie(n, n2);
        }

        static void ImprimeSerie(int n1, int n2)
        {
            int i;

            if (n1 < n2)
            {
                i = n1;
                while (i <= n2)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            else
            {
                i = n1;
                while (i >= n2)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }
        }    
    }
}
