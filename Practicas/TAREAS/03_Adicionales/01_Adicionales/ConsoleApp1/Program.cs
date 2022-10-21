using System;

namespace ConsoleApp1
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

            PrimosRelativos(n,n2);

        }

        //static int mcd(int a, int b)
        //{
        //    int min, i;

        //    min = a < b ? a : b;

        //    i = min;

        //    while (a % i != 0 || b % i != 0)
        //    {
        //        i--;
        //    }

        //    return i;
        //}

        static void PrimosRelativos(int a, int b)
        {
            if (MCD2(a,b) == 1 )
            {
                Console.WriteLine($"{a} y {b} son primos relativos");
            }
            else
            {
                Console.WriteLine($"{a} y {b} no son primos relativos");
            }
        }

        static int MCD2(int a, int b)
        {
            int i, min, max, mcd;
            max = 1;
            min = 1;
            mcd = 1;

            if (a > b)
            {
                a = max;
                b = min;
            }
            else
            {
                b = max;
                a = min;
            }

            for (i = min; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }


    }
}
