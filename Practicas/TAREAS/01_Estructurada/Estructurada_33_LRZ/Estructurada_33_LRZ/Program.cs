using System;

namespace Estructurada_33_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, i, n;
            double suma, media;

            Console.WriteLine("Dime un número ");
            n = int.Parse(Console.ReadLine());

            min = n;
            max = n;
            suma = n;

            for (i = 1; i < 10; i++)
            {

                Console.WriteLine("Introduzca otro número");

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
            }

            media = suma / i;

            Console.WriteLine("El mín es : " + min + " El máx es : " + max + " La media es : " + media);



        }
    }
}
