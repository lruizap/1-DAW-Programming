using System;

namespace _18_Adicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime cuántas veces quieres sumar");
            n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Necesitas sumar números positivos");
                Console.WriteLine("Dime otro número");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma total es de " + SumaNumero(n));
        }

        static int SumaNumero(int n)
        {
            int i, suma, numero;
            suma = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Dime un número");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Dime un número");
                    numero = int.Parse(Console.ReadLine());
                }

                suma = suma + numero;
            }
            return suma;
        }
    }
}
