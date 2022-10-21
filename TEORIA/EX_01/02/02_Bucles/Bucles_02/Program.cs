using System;

namespace Bucles_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // bucles --> mientras... hace esto 

            double n;

            Console.WriteLine("Dime un número");
            n = double.Parse(Console.ReadLine());

            while (n != 5)
            {
                Console.WriteLine("Ese número no me gusta, Escribe otro");
                n = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Por el culo te la hinco");
  
        }
    }
}
