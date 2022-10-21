using System;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Dime un número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }
        }
    }
}
