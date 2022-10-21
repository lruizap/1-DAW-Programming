using System;

namespace _04_Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("¿Cuántos años tienes?");
            edad = int.Parse(Console.ReadLine());

            while (edad < 0 || edad > 125)
            {
                Console.WriteLine("Eso es imposible, inténtalo otra vez");
                edad = int.Parse(Console.ReadLine());
            }

            if (edad >= 18)
            {
                Console.WriteLine("Vamonos de botellón");
            }
            else
            {
                Console.WriteLine("Tómate un Trina");
            }

        }
    }
}
