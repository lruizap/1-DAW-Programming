using System;

namespace Funciones_01_Par_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());

            if (espar(n))
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }
        }

        static bool espar(int n)
        {
            bool resultado;

            if (n % 2 == 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

    }
}
