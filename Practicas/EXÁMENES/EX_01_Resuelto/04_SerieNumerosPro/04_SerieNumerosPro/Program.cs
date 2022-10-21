using System;

namespace _04_SerieNumerosPro
{
    class Program
    {
        static void Main(string[] args)
        {
            SerieNumerosPro(1,9,4);
        }

        static void SerieNumeros(int a, int b)
        {
            int i;

            if (a < b)
            {
                for (i = a; i < b; i++)
                {
                    Console.WriteLine(i + " ");
                }
            }
            else
            {
                for (i = a; i > b; i--)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        static void SerieNumerosPro(int a, int b, int c)
        {
            SerieNumeros(a, b);
            SerieNumeros(b, c);
            Console.WriteLine(c);
            SerieNumeros(c, b);
            SerieNumeros(b, a);
            Console.WriteLine(a);
        }
    }
}
