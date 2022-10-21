using System;

namespace Funciones_05_Signo_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());
            signo(n);
        }

        static void signo(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                if (n == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            return;
        }

    }
}
