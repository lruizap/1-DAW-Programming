using System;

namespace Estructurada_02_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("Dime el año");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.WriteLine("Este año ES bisiesto");
            }
            else
            {
                Console.WriteLine("Este año NO es bisiesto");
            }

        }
    }
}
