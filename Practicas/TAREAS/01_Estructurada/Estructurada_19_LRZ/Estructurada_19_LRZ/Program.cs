using System;

namespace Estructurada_19_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, A, aprob, susp;
            double nota;
            A = 30;
            aprob = 0;
            susp = 0;
            i = 1;

            while (i <= A)
            {
                Console.WriteLine("Dime la nota del alumno " + i + " :");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <=10)
                {
                    if (nota >= 5)
                    {
                        aprob++;
                    }
                    else
                    {
                        susp++;
                    }


                    i++;
                }
                else
                {
                    Console.WriteLine("Esa nota no es válida, por favor, introduzca una nota exacta");
                }
            }
            Console.WriteLine("Estos son los aprobados " + aprob + "; y estos son los suspensos " + susp);
        }
    }
}
