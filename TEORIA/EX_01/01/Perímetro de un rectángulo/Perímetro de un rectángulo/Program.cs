using System;

namespace Perímetro_de_un_rectángulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, resultado;


            Console.WriteLine("dime la longitud del lado a");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("dime la longitud del lado b");
            B = double.Parse(Console.ReadLine());

            resultado = (A * 2) + (B * 2);

            Console.WriteLine("El perímetro del rectángulo es " + resultado);
        }
    }
}
