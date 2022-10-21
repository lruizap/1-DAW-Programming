using System;

namespace Estructurada_08_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Dime el PRIMER Número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el SEGUNDO Número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el TERCER Número");
            c = int.Parse(Console.ReadLine());

            if ((a <= b) && (b <= c))
            {
                Console.WriteLine("El pequeño es " + a + " El mediano es " + b + " El mayor es " + c);
            }
            else
            {
                if ((a <= c) && (c <= b))
                {
                    Console.WriteLine("El pequeño es " + a + " El mediano es " + c + " El mayor es " + b);
                }
                else
                {
                    if ((b <= a) && (a <= c))
                    {
                       Console.WriteLine("El pequeño es " + b + " El mediano es " + a + " El mayor es " + c);
                    }
                    else
                    {
                        if ((b <= c) && (c <= a))
                        {
                            Console.WriteLine("El pequeño es " + b + " El mediano es " + c + " El mayor es " + a);
                        }
                        else
                        {
                            if ((c <= a) && (a <= b))
                            {
                               Console.WriteLine("El pequeño es " + c + " El mediano es " + a + " El mayor es " + b);
                            }
                            else
                            {
                                    Console.WriteLine("El pequeño es " + c + " El mediano es " + b + " El mayor es " + a);
                            }
                        }
                    }
                }
            }
        }
    }
}
