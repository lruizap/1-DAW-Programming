using System;

namespace Estructurada_18_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, n;
            double media, suma;
            cont = 0;
            suma = 0;
            Console.WriteLine("Dime un número (escribe un negativo para terminar)");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                suma = suma + n;
                cont++;

                Console.WriteLine("Dime un número (escribe un negativo para terminar)");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("La suma es : " + suma);
            media = suma / cont;
            Console.WriteLine("La media es : " + media);
        }
    }
}
