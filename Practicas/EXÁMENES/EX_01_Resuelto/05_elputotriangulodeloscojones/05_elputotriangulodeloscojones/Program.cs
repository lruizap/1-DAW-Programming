using System;

namespace _05_elputotriangulodeloscojones
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam;
            Console.WriteLine("Dime el tamaño");
            tam = int.Parse(Console.ReadLine());
            PiramideNumero(tam);
        }

        static void PiramideNumero(int tam)
        {
            int i, j;

            for (i = 1; i <= tam; i++)
            {
                Console.WriteLine();
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j % 10);
                }

            }
        }
    }
}
