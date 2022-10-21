using System;

namespace Estructurada_24_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, c;
            i = 1;
            c = 10;

            for (i = 1; i < c; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
