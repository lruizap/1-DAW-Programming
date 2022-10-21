using System;

namespace Estructurada_35_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double n;

            Console.WriteLine("Dime la nota de tu alumno");
            n = double.Parse(Console.ReadLine());

            i = 0;

            while (i < 1)
            {
                if ((n >= 0) && (n <= 9))
                {
                    if (n < 5)
                    {
                        Console.WriteLine("Estas suspenso");
                    }
                    else
                    {
                        if (n <= 6)
                        {
                            Console.WriteLine("Bien");
                        }
                        else
                        {
                            if (n <= 7)
                            {
                                Console.WriteLine("Notable");
                            }
                            else
                            {
                                if (n <= 9)
                                {
                                    Console.WriteLine("Sobresaliente");
                                }
                            }
                        }
                    }
                    
                    i++;
                }
                else
                {
                    Console.WriteLine("La nota no es válida, por favor, introduzca un valor válido");
                    n = double.Parse(Console.ReadLine());
                }

                
            }
        }
    }
}
