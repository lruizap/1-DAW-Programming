using System;

namespace Funciones_02_Bisiesto_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime Un año");
            n = int.Parse(Console.ReadLine());

            if (esbisiesto(n))
            {
                Console.WriteLine("Es bisiesto");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }

        }

        static bool esbisiesto(double n)
        {
            bool resultado;

            if (n % 400 == 0)
            {
                resultado = true;
            }
            else
            {
                if (n % 4 == 0 && n % 100 !=0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            return (resultado);
        }

    }
}
