using System;

namespace Estructurada_25_LRZ_Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n =1;
            if (n % 2 == 1)
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    Console.WriteLine(n);
                    n = n + 2;
                }
            }
        }
    }
}
