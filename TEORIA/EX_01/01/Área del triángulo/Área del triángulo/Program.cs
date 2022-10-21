using System;
using System.Diagnostics;

namespace Área_del_triángulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura, area;

            Console.WriteLine("Dime la base del triángulo");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("dime la altura del triángulo");
            altura = double.Parse(Console.ReadLine());

            area = (base1 * altura) / 2;

            Console.WriteLine("el área del triángulo es " + area);
        }
    }
}