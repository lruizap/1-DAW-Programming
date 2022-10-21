using System;

namespace Positivo_Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("CERO");
            }
            else
            {
                if (n > 0)
                {
                    Console.WriteLine("Positivo");
                }
                else
                {
                    Console.WriteLine("Negativo");
                }
            } 
        }
    }
}
