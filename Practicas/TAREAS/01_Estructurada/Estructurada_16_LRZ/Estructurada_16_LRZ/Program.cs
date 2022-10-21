using System;

namespace Estructurada_16_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, max, min;

            Console.WriteLine("Introduce un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Estos son los números impares introducidos entre estos 2 : ");

            if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = b;
                max = a;
            }

            i = min;
            while (i <= max)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;

                // para intercambiar 2 variables, hay que guardar la variable a en temp y luego se cambia a por b y b por temp
            }
        }
    }
}
