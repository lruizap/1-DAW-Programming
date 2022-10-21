using System;

namespace pentágono
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1, x, y;
            base1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (x = 1; x <= base1; x++)
            {
                for (y = base1 - x; y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (y = 1; y < x; y++)
                {
                    Console.Write("**");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (x = 1; x <= base1; x++)
            {
                for (y = 1; y <= base1; y++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
        }
    }
}
