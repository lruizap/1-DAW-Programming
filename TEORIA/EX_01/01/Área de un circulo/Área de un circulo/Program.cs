using System;

namespace Área_de_un_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, area;

            Console.WriteLine("Dime el radio del círculo");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * (radio * radio);

            Console.WriteLine("el área del círculo es " + area);


        }
    }
}
