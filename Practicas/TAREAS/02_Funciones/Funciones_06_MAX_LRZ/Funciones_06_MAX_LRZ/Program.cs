using System;

namespace Funciones_06_MAX_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El mayor es " + MAX(n, n2));
        }

        static int MAX(int n, int n2)
        {
            int res;
            if (n > n2)
            {
                res = n;
            }
            else
            {
                res = n2;
            }

            return res;
        }
    }
}
