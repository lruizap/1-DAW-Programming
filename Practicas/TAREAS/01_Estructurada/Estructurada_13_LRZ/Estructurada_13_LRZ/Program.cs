using System;

namespace Estructurada_13_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, Multiplicacion;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());


            i = 1;

            while (i <= 10)
            {
                Multiplicacion = i * n;
                Console.WriteLine(n + " x " + i + " = " + Multiplicacion);

                i++;
            }


        }
    }
}
