using System;

namespace Adicional_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime un número entre 3 y 20");
            n = int.Parse(Console.ReadLine());

            RomboEstrellitas(n);

        }

        static void RomboEstrellitas(int n)
        {
            int i, j;
            j = n;

            while (n < 3 || n > 20)
            {
                Console.WriteLine("ERROR, porfavor, introduzca un valor correcto");
                n = int.Parse(Console.ReadLine());
            }
            n = n - 1;

            for (j = 1; j <= n; j++)
            {
                Console.WriteLine();

                for (i = 0; i < n - j; i++)
                {
                    Console.Write(" ");
                }

                for (i = 0; i < j * 2; i++)
                {
                    Console.Write("*");
                }
            }
            for (j = n - 1; j >= 0; j--)
            {
                Console.WriteLine();

                for (i = 0; i < n - j; i++)
                {
                    Console.Write(" ");
                }

                for (i = j * 2; i > 0; i--)
                {
                    Console.Write("*");
                }
            }

            //for (i = 0; i <= n; i++)
            //{
            //    Console.WriteLine();

            //    for (j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //        Console.Write(" ");
            //    }
            //}

            //for (i = n - 1; i >= 0; i--)
            //{
            //    Console.WriteLine();

            //    for (j = i * 2; j >= i; j--)
            //    {
            //        Console.Write("*");
            //        Console.Write(" ");
            //    }
        }
    }
}
