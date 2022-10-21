using System;

namespace Estructurada_06_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime el número");
            n = int.Parse(Console.ReadLine());

            if (n > -10 && n < 10)
            {
                Console.WriteLine("1 cifra");
            }
            else
            {
                if (n > -100 && n < 100)
                {
                    Console.WriteLine("2 cifras");
                }
                else
                {
                    if (n > -1000 && n < 1000)
                    {
                        Console.WriteLine("3 cifras");
                    }
                    else
                    {
                        if (n > -10000 && n < 10000)
                        {
                            Console.WriteLine("4 cifras");
                        }
                        else
                        {
                            Console.WriteLine("5 cifras o más");
                        }
                    }
                }
            }
        }
    }
}
