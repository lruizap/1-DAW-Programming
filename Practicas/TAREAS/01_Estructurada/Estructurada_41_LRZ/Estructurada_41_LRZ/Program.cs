using System;

namespace Estructurada_41_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 2; i <= 1000; i++)
            {
                if (esprimo(i))
                {
                    Console.WriteLine(i);
                }
                else
                {

                }
            }
        }

        static bool esprimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
