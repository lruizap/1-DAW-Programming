using System;

namespace Estructurada_30_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {

            int suma;
            Console.WriteLine("La suma de todos los números pares entre 1 y 1000 es:");

            suma = 0;

            for (int i = 0; i <= 1000 ; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
        }
    }
}
