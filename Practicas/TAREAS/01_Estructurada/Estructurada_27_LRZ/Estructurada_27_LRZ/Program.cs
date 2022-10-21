using System;

namespace Estructurada_27_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, Multiplicacion;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            for (int cont = 0; cont <= 10; cont++)
            {
                Multiplicacion = cont * n;
                Console.WriteLine(n + " x " + cont + " = " + Multiplicacion);
            }

        }
    }
}
