using System;

namespace Estructurada_37_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            double i;
            i = 1;
            Console.WriteLine("Elige una opción (a, b ó c)");
            opcion = Console.ReadLine();

            if ((opcion == "a") || (opcion == "A"))
            {
                for (i = 1; i < 100; i++)
                {
                    if (i % 11 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            else
            {
                if ((opcion == "b") || (opcion == "B"))
                {
                    for (i = 1; i < 100; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    if ((opcion == "c") || (opcion == "C"))
                    {
                        for (i = 1; i < 100; i++)
                        {
                            if (i % 23 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR");

                    }
                }

            }

        }
    }
}