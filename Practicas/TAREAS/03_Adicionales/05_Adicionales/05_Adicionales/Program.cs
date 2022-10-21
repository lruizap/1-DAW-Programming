using System;

namespace _05_Adicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime un número entre 3 y 20");
            n = int.Parse(Console.ReadLine());

            TrianguloEstrellitas(n);

        }

        static void TrianguloEstrellitas(int n)
        {
            int i, j;
            j = n;
             
            while (n < 3 || n > 20)
            {
                Console.WriteLine("ERROR, porfavor, introduzca un valor correcto");
                n = int.Parse(Console.ReadLine());
            }
            n = n - 1;

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine();

                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
            }
        }
    }
}
