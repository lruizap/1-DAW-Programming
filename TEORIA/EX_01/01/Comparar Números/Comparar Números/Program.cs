using System;

namespace Comparar_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Dime el primer número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo número");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " > " + n2);
            }
            else
            {
                if (n1 == n2)
                {
                    Console.WriteLine(n1 + " = " + n2);
                }
                else
                {
                    Console.WriteLine(n1 + " < " + n2);
                }
            }

        }
    }
}
