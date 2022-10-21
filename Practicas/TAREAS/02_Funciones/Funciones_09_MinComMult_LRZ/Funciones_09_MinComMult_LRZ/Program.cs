using System;

namespace Funciones_09_MinComMult_LRZ
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

            Console.WriteLine("El MCM es " + MCM(a, b));
        }

        static int MCM(int a, int b)
        {
            int i = a;

            while (i <= a * b)
            {
                if ((i % a == 0) && (i % b == 0))
                {
                    break;
                }

                i++;
            }

            return i;
        }
    }
}
