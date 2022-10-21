using System;

namespace Estructurada_21_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, n, i;
            double media, suma;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            max = n;
            min = n;
            suma = n;

            i = 1;
            while (i < 10)
            {
                Console.WriteLine("Dime otro número");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
                suma = suma + n;
                i++;

            }
            media = (suma) / i;
            Console.WriteLine("El valor máx es : " + max + " , el mínimo es : " + min + " y la media es : " + media);
        }
    }
}
