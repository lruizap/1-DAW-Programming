using System;

namespace _05_WhileContador
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = -10;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;                // i++ = (i = i + 1) solo cuando valla suelto en una línea con su ;
            }
        }
    }
}
