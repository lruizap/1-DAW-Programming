using System;

namespace _02_ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] a = new int[3][4];

            int[,] a = new int[3, 4];

            int[,] a2 = { { 1, 0, 12, -1 }, { 7, -3, 2, 5 }, { -5, -2, 2, -9 } };

            a[0, 0] = 10;
            Console.WriteLine(a[0,0]);
            Console.WriteLine(a2[2,3]);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(a2[i,j]);
                }
            }

            //for (int i = 0; i < a2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a2[i, j]);
            //    }
            //}

            //for (int k = 0; k < 3*4; k++)
            //{
            //    Console.WriteLine(a2[k/4, k%4]);
            //}

            Console.WriteLine(a2.Rank); // nº dimensiones 

            EscribeArrayMult(a2);


        }

        static void EscribeArrayMult(int[,] a)
        {
            int i, j, k;
            Console.Write("╔");

            for (j = 0; j < 1+a.GetLength(1); j++)
            {
                Console.Write("\t");
            }

            Console.WriteLine("╗");
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("║");
                Console.Write("\t");
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine("║");
            }
            Console.Write("╚");

            for (j = 0; j < 1+a.GetLength(1); j++)
            {
                Console.Write("\t");
            }
            Console.Write("╝");
        }
    }
}
