using System;

namespace _03_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, suma;

            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("dime otro numero");
            b = int.Parse(Console.ReadLine());

            suma = Suma2(b, a)

            Console.WriteLine("La suma es " + suma);
            Console.WriteLine(a);
        }

        static int Suma2(int a, int b)
        {
            int suma;
            suma = a + b;
            a = -1;

            return suma;  
        }
    }
}
