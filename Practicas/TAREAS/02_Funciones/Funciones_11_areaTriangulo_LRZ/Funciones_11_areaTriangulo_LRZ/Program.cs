using System;

namespace Funciones_11_areaTriangulo_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h;
            Console.WriteLine("Vamos a calcular el área del triángulo");
            Console.WriteLine("Dime la base del triángulo");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la altura del triángulo");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("El área del triángulo es :" + areaTriangulo(b,h));

        }

        static double areaTriangulo(double b, double h)
        {
            double res;

            res = ((b * h) / 2);

            return res;
        }

    }
}
