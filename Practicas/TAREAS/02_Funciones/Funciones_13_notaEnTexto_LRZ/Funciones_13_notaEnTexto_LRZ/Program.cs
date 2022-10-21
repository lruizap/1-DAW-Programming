using System;

namespace Funciones_13_notaEnTexto_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Dime la nota del alumno");
            n = double.Parse(Console.ReadLine());

            notaEnTexto(n);
        }

        static double notaEnTexto(double n)
        {
            if (valida(n) == true)
            {
                if (n < 5)
                {
                    Console.WriteLine("Esta suspenso");
                }
                else
                {
                    if (n == 5)
                    {
                        Console.WriteLine("Suficiente");
                    }
                    else
                    {
                        if (n == 6)
                        {
                            Console.WriteLine("Bien");
                        }
                        else
                        {
                            if (n <= 8)
                            {
                                Console.WriteLine("Notable");
                            }
                            else
                            {
                                if (n <= 10 )
                                {
                                    Console.WriteLine("Sobresaliente");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, Por favor, introduzca una nota válida (Entre 0 y 10)");
            }
            return n;
        }

        static bool valida(double n)
        {
            bool res;
            if (n < 0 || n > 10)
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
    }
}
