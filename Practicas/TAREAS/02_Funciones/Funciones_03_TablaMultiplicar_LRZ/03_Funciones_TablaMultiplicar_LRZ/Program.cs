using System;

namespace _03_Funciones_TablaMultiplicar_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            tablamultiplicar(n);
        }

        static void tablamultiplicar(int n)
        {
            double resultado;
            
            for (int i = 0; i <= 10; i++)
            {
                resultado = i * n;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }
        } 
    }
}
