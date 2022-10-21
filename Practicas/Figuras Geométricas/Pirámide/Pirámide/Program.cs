using System;

namespace Pirámide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, esp, asteriscos;
            Console.WriteLine("Dime la altura de la pirámide (3-20)");
            n = int.Parse(Console.ReadLine());

            while ((n<3)|| (n>20))
            {
                Console.WriteLine("ERROR, porfavor, introduzca un valor válido (3-20)");
                n = int.Parse(Console.ReadLine());
            }

            for (i = 1; i <= n ; i++) // me cuenta los saltos de linea
            {
                Console.WriteLine();
                for (esp = 0; esp < n-i; esp++) // me cuenta los espacios 
                {
                    Console.Write(" ");
                }

                for (asteriscos = 0; asteriscos < (i*2) -1; asteriscos++)
                {
                    Console.Write("$");
                }
            }

            for (i = n-1; i >= 0; i--) // me cuenta los saltos de linea
            {
                Console.WriteLine();
                for (esp = 0; esp < n - i; esp++) // me cuenta los espacios 
                {
                    Console.Write(" ");
                }

                for (asteriscos = 0; asteriscos < (i * 2) - 1; asteriscos++)
                {
                    Console.Write("$");
                }
            }
        }
    }
}
