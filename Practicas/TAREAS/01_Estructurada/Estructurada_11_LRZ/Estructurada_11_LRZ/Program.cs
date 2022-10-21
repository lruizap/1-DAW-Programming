using System;

namespace Estructurada_11_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador;
            i = 1;
            contador = 0;

            while (contador < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    contador++;
                }
                i++;
            }

        }
    }
}
