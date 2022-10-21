using System;

namespace Funciones_16_elevado_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime cuántas veces lo quieres elevar");
            b = int.Parse(Console.ReadLine());

            elevado(a, b);
        }

        static int elevado(int a, int b)
        {
            for (int i = 1; i <= b; i++)
            {
                a = a * i;
                
            }
            Console.WriteLine(a);

            return a;
        }
    }
}
