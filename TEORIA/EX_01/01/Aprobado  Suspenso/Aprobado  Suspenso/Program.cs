using System;

namespace Aprobado__Suspenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("¿Qué nota has sacado en LDM?");

            nota = double.Parse(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Has suspendido");
            }
            else
            {
                Console.WriteLine("Has Aprobado");   
            }



        }
    }
}
