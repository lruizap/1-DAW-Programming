using System;

namespace Estructurada_12_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, i;
            string opcion;
            p = 2;
            i = 1;

            Console.WriteLine("Elige, Par o Impar");
            opcion = Console.ReadLine();

            if ((opcion == "par") || (opcion == "pares"))
            {
                Console.WriteLine("Los números pares del 1 al 10 son: ");
                while (p <= 10)
                {
                    Console.WriteLine(p);
                    p = p + 2;
                }

            }
            else
            {
                if ((opcion == "impar") || (opcion == "impares"))
                {
                    Console.WriteLine("Los números impares del 1 al 10 son: ");
                    while (i <= 10)
                    {
                        Console.WriteLine(i);
                        i = i + 2;
                    }
                }
                else
                {
                    Console.WriteLine("Escriba un valor válido");
                }
            }

        }
    }
}
