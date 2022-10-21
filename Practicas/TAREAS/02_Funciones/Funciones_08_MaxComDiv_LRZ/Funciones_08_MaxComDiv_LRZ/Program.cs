using System;

namespace Funciones_08_MaxComDiv_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número");
            b = = int.Parse(Console.ReadLine());
            Console.WriteLine("El MCD es " + Mcd(a, b));
        }

        static int Mcd(int a, int b)
        {
            int i, res;
            i = a;
            res = 1;

            while (i >= 1)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    res = i;
                    break;
                }

                i--;
            }

            return res;
        }
    }
}
