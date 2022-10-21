using System;

namespace Funciones_14_leeNatural_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = leeNatural();
        }

        static int leeNatural()
        {
            int n;

            Console.WriteLine("Dime un número natural");
            n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("ERROR, el número debe ser natural. Escríbelo otra vez");
                n = int.Parse(Console.ReadLine());
            }

            return n;
        }
    }
}
