using System;

namespace numerorandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero, i = 0;

            Console.WriteLine("Dime un número");
            numero = int.Parse(Console.ReadLine());

            Random r = new Random();
            n = r.Next(1, 100 + 1);

            while (numero != n)
            {
                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("ERROR, introduzca un númmero dentro del intervalo (1-100)");
                }
                if (numero > n)
                {
                    Console.WriteLine("prueba uno menor");

                }
                else
                {
                    Console.WriteLine("prueba uno mayor");
                }

                i++;

                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¡Has acertado!, el número era " + n + " el número de intentos es de : " + i);
        }
    }
}
