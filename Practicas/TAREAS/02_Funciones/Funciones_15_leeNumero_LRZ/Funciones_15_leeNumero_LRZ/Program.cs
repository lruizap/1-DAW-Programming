using System;

namespace Funciones_15_leeNumero_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            leeNumero(a, b);
        }

        static int leeNumero(int a, int b)
        {
            int i;
            i = 1;
            if (a > b)
            {
                for (i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                if (a < b)
                {
                    for (i = a; i <= b; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            return i;
        }
    }
}
