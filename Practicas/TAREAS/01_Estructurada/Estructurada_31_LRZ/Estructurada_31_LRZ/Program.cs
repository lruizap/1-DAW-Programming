using System;

namespace Estructurada_31_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ap, sus;
            ap = 0;
            sus = 0;
            for (int i= 0; i< 30;)
            {
                Console.WriteLine("Dime la nota de tu alumno");
                n = int.Parse(Console.ReadLine());

                if ((n >= 0) && (n <= 10))

                {
                    if (n >= 5)
                    {
                        Console.WriteLine("Esta aprobado");
                        ap++;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Esta Suspenso");
                        sus++;
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, introduce una nota válida entre 0 y 10");

                }
            }
            Console.WriteLine("Hay " + ap + " aprobados y hay " + sus + " suspensos");
        }
    }
}
