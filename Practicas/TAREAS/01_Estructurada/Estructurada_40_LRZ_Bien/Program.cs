using System;

namespace Estructurada_40_LRZ_Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dime un numero para saber si es primo");
            int num;

            num = int.Parse(Console.ReadLine());


            if (EsPrimo(num))
            {
                Console.WriteLine("es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }

        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    
                    return false;
                }
            }

            return true;
        }
    }
}

