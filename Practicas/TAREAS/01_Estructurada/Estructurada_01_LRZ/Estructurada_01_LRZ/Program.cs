using System;

namespace Estructurada_01_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultadoa, resultadob;
            Console.WriteLine("Dime el primer Número");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo Número");
            b = double.Parse(Console.ReadLine());

            resultadoa = (a - b);

            resultadob = (b - a);

            if (a > b)
            {
                Console.WriteLine("el resultado es " + resultadoa);
            }
            else
            {
                Console.WriteLine("el resultado es " + resultadob);
            }

            // Math.Abs(VALOR ABSOLUTO)

        }
    }
}
