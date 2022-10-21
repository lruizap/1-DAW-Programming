using System;

namespace División_y_resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, cociente, resto;

            Console.WriteLine("dime un número");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("... dividido entre");
            n2 = int.Parse(Console.ReadLine());

            cociente = n1 / n2;
            resto = n1 % n2;

            Console.WriteLine("El cociente es " + cociente + " y el resto es " + resto);

        }
    }
}
