using System;

namespace El_número_mágico
{
    class Program
    {
        static void Main(string[] args)
        {
            double doble, numero;

            Console.WriteLine("Dime un número");
            numero = double.Parse(Console.ReadLine());
            if (numero == 5)                               // Para comparar números se pone el igual 2 veces
            {
                Console.WriteLine("Por el culo te la hinco");

            }
            else
            {
                doble = numero * 2;
                Console.WriteLine("El doble del número es " + doble);
         
            }
        }
    }
}
