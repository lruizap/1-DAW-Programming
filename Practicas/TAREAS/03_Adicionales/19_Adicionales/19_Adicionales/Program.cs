using System;

namespace _19_Adicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Dime otro número");
            n2 = int.Parse(Console.ReadLine());

            ProgresionAritmetica(n, n2);
        }

        static void ProgresionAritmetica(int n, int n2)
        {
            int resta;

            resta = n2 - n;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n);
                n = n + resta;
            }          
        }
    }
}
