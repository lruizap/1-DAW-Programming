using System;

namespace Estructurada_15_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i;
            Console.WriteLine("Dime el primer número");
            n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Dime el segundo número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Estos son los números comprendidos entre el primer y el segundo número :");


            if (n1 < n2)
            {
                i = n1;
                while (i <= n2)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            else
            {
                i = n1;
                while (i >=n2)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }
        }
    }
}
