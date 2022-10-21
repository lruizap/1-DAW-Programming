using System;

namespace Estructurada_05_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("Introduce el número x");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el número y");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el número z");
            z = double.Parse(Console.ReadLine());

            if ((x+1==y) && (x+2==z))
            {
                Console.WriteLine("Los Números SON consecutivos");
            }
            else
            {
                Console.WriteLine("Los números no son consecutivos");
            }
        }
    }
}
