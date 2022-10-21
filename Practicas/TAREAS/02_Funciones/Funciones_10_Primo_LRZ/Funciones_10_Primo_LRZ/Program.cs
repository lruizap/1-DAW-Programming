using System;

namespace Funciones_10_Primo_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            if (primo(n))
            {
                Console.WriteLine("Es Primo");
            }
            else
            {
                Console.WriteLine("No es Primo");
            }
        }

        static bool primo(int n)
        {
            int i, divisores;
            divisores = 0;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisores++;
                    break;
                }
            }

            if (divisores == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
