using System;

namespace _05_Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, suma;

            i = 0;
            suma = 0;

            while (i <= 500)
            {
                suma = suma + i;
                Console.WriteLine(suma);

                i++;
            }

            Console.WriteLine("La suma total es " + suma);
        }
    }
}
