using System;

namespace Volumen_de_un_toro
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, r, resultado;

            Console.WriteLine("Introduce Radio MAYOR");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Radio MENOR");
            r = double.Parse(Console.ReadLine());

            resultado = 2 * (Math.PI * Math.PI) * R * (r * r);

            Console.WriteLine("El resultado es :" + resultado);
        }
    }
}
