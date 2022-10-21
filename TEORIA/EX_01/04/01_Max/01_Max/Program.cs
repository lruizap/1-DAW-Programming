using System;

namespace _01_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, 2, 3, 4, 5, 6

            int max, n, i;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            max = n;

            i = 1;
            while (i < 9)
            {
                Console.WriteLine("Dime otro número");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }

                i++;
            }

            Console.WriteLine(max);


        }
    }
}
