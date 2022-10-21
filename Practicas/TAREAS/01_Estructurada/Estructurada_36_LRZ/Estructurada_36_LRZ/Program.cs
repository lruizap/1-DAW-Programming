using System;

namespace Estructurada_36_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
