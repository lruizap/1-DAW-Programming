using System;

namespace Estructurada_07_LRZ_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double raiz, resultado, resultado1, resultado2;
            Console.WriteLine("Introduce tres números");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            raiz = (b * b) - (a * c * 4);

            if (raiz > 0)
            {
                resultado1 = ((-b) + Math.Sqrt(raiz)) / (2 * a);
                resultado2 = ((-b) - Math.Sqrt(raiz)) / (2 * a);
                Console.WriteLine("Los resultados de la ecuación son " + resultado1 + " y " + resultado2);
            }
            else
            {
                if (raiz == 0)
                {
                    resultado = (-b) / (2 * a);
                    Console.WriteLine("El resultado de la ecuación es " + resultado);

                }
                else
                {
                    Console.WriteLine("No existe solución real");
                }
            }
        }
    }
}