using System;

namespace _06_Condición
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador;
            i = 1;
            contador = 0;
            while (i <=200)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    contador++;
                }

                i++;
            }
            Console.WriteLine("Hay " + contador + " multiplos de 7");
        }
    }
}


// i = 1;
// cont = 0;

// while (cont < 10)
// if (i % 7 == 0)