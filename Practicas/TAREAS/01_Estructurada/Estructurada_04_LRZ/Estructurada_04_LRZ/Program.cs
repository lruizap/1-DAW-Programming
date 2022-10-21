using System;

namespace Estructurada_04_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("Escribe número x");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe número y");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe número z");
            z = double.Parse(Console.ReadLine());

            if ((x <= y ) && ( y <= z ))
            {
                Console.WriteLine("Los Números están ordenados de menor a mayor");
            }
            else
            {
                if (x > y)
                {
                    Console.WriteLine("No estan ordenados de menor a mayor");
                }
                else
                {
                 
                }
                if (y > x)
                {
                    Console.WriteLine("No estan ordenados de menor a mayot");
                }
                else
                {

                }
            }
        }
    }
}
