using System;

namespace circulo_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el radio del círculo");
            int x, y, radio;
            radio = int.Parse(Console.ReadLine());
            for (x = 0; x <= (radio * 2); x++)
            {
                for (y = 0; y <= (radio * 2); y++)
                {
                    if (Math.Pow((y - radio), 2) + Math.Pow((x - radio), 2) <= Math.Pow(radio, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }

            int h = int.Parse(Console.ReadLine());
            int x, y;
            Console.Write(" ");
            Console.WriteLine();
            for (x = 1; x <= h; x++)
            {
                for (y = h - x; y > 0; y--)
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
        }
    }
}
