using System;

namespace Nota_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Dime tu nota");
            nota = double.Parse(Console.ReadLine());

            while ((nota < 0) || (nota > 10 )) //while(!(nota >=0 && nota <=10))
            {
                Console.WriteLine("La Nota no es correcta, escribala otra vez");
                nota = double.Parse(Console.ReadLine());
            }

            if (nota >=5)
            {
                Console.WriteLine("Estas Aprobado");
            }
            else
            {
                Console.WriteLine("Estas suspenso");
            }
        }
    }
}
