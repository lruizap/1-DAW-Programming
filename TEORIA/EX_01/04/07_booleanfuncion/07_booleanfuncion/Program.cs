using System;

namespace _07_booleanfuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma;
            suma = 0;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            while (EsPositivo(n))
            {
                suma = suma + n;

                Console.WriteLine("Dime un número");
                n = int.Parse(Console.ReadLine());
            }
        }

        static bool EsPositivo(int n)
        {
            bool resultado;
            if (n > 0)
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
