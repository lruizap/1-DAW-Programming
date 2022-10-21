using System;

namespace Cálculo_SUMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, suma;

            Console.WriteLine("Dime el primer número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;

            Console.WriteLine("La suma es " + suma);



        }
    }
}
