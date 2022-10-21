using System;

namespace Estructurada_26_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int cont;
            cont = 10;

            Console.WriteLine("Elige : Par o Impar");
            opcion = Console.ReadLine();

            if ((opcion == "par") || (opcion == "pares"))
            {
                Console.WriteLine("Los números pares del 1 al " + cont + " son : ");
                for (int i = 2; i <= cont; i = i + 2)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                if ((opcion == "impar") || (opcion == "impares"))
                {
                    Console.WriteLine("Los números impares del 1 al " + cont + " son : ");
                    for (int i = 1; i <= cont; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Escriba una opción válida");
                }
            }
        }
    }
}
