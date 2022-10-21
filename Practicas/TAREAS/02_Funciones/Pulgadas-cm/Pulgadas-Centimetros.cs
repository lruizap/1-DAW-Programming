using System;

namespace Funciones_12_cpulgadasACentimetros_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            string opcion;

            Console.WriteLine("El programa pasará la altura de una unidad a otra.");
            Console.WriteLine("Elige a la unidad que quieres que pasar, centimetros o pulgadas");
            opcion = Console.ReadLine();

            Console.WriteLine("Dime la altura");
            h = double.Parse(Console.ReadLine());

            if ((opcion == "centimetros") || (opcion == "centímetros"))
            {
                Console.WriteLine("La altura en centímetros es :" + pulgadasACentimetros(h));
            }
            else
            {
                if ((opcion == "pulgadas") || (opcion == "pulgada"))
                {
                    Console.WriteLine("La altura en centímetros es :" + centimetrosAPulgadas(h));
                }
            }
        }

        static double pulgadasACentimetros(double h)
        {
            double res;
            res = (h * 2.54);
            return res;
        }

        static double centimetrosAPulgadas(double h)
        {
            double res;
            res = (h / 2.54);
            return res;
        }
    }
}
