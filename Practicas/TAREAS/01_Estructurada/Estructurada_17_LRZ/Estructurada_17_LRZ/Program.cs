using System;

namespace Estructurada_17_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, suma;
            Console.WriteLine("La suma de todos los números pares entre 1 y 1000 es:");

            i = 2;
            suma = 0;
            
            while (i <= 1000)
            {
                suma = suma + i;
                i = i + 2;
            }

            Console.WriteLine(suma);


        }
    }
}
