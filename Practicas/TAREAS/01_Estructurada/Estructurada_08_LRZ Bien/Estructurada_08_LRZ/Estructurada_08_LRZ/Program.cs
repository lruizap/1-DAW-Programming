using System;

namespace Estructurada_08_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Dime el primer número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número");
            c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if (a < c)
                {
                    if (c < b)
                    {
                        Console.WriteLine(a + " es el menor, " + c + " es el mediano " + "y " + b + " es el mayor");
                    }
                    else
                    {
                        Console.WriteLine(a + " es el menor, " + b + " es el mediano " + "y " + c + " es el mayor");
                    }
                }
                else
                {
                    Console.WriteLine(c + " es el menor, " + a + " es el mediano " + "y " + b + " es el mayor");
                }
            }
            else
            {
                if (b < c)
                {
                    if (c < a)
                    {
                        Console.WriteLine(b + " es el menor, " + c + " es el mediano " + "y " + a + " es el mayor");
                    }
                    else
                    {
                        Console.WriteLine(b + " es el menor, " + a + " es el mediano " + "y " + c + " es el mayor");
                    }
                }
                else
                {
                    Console.WriteLine(c + " es el menor, " + b + " es el mediano " + "y " + a + " es el mayor");
                }
            }
        }
    }
}