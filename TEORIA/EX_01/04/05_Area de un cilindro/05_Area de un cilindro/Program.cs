using System;

namespace _05_Area_de_un_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, altura, volumen;

            Console.WriteLine("Vamos a calcular el volumen del cilindro");
            Console.WriteLine("dime el radio");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la altura");
            altura = double.Parse(Console.ReadLine());

            volumen = AreaCirculo(radio) * altura;

            Console.WriteLine("El volumen del cilindro es " + volumen);

        }

        static double AreaCirculo(double radio)
        {
            double area;

            area = Math.PI * radio * radio;

            return area;
        }

    }
}
