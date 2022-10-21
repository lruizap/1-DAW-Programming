using System;

namespace Estructurada_42_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero = -1, i = 1;

            Console.WriteLine("Dime un número");
            numero = int.Parse(Console.ReadLine());

            Random r = new Random();
            n = r.Next(1, 100 + 1);

            while (n != numero)
            {
                Console.WriteLine("Dime un número");
                numero = int.Parse(Console.ReadLine());
                if (n < numero)
                {
                    Console.WriteLine("Es menor");
                }
                else
                {
                    Console.WriteLine("Es mayor");
                }

                i++;
            }
            Console.WriteLine("Acertaste, " + " número de intentos : " + i);
        }
    }
}
