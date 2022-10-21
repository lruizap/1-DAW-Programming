using System;

namespace AND
{
    class Program
    {
        static void Main(string[] args)
        {
            // && = Y
            //if ((n1 >= -10) && (n1 <= 10)) (solo si las 2 son vda)

            // || = o 
            //if ((n1 >= 5) || (n2 >=5))  (si al menos 1 de las 2 es vda)

            //! delante de algo = NO --> La invierte
            // if (!(n1 > n2))

            double nota;
            Console.WriteLine("Dime la nota que has sacado");
            nota = double.Parse(Console.ReadLine());

            if ((nota >= 0) && (nota <=10))
            {
                if (nota >= 5)
                {
                    Console.WriteLine("Has Aprobado");
                }
                else
                {
                    Console.WriteLine("Has Suspendido");
                }
            }
            else
            {
                Console.WriteLine("Nota no válida");
            }
        }
    }
}
