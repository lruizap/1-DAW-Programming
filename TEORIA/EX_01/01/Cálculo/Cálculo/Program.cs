using System;

namespace Cálculo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            int doble;
         

            Console.WriteLine("dime un número");
            n = int.Parse(Console.ReadLine());

            doble = n * 2;
           
            Console.WriteLine("El doble es " + doble);

        }
    }
}
