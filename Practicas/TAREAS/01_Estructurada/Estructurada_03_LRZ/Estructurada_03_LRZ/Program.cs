using System;

namespace Estructurada_03_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, p;
            string opcion;

            Console.WriteLine("¿En que quieres convertir? (euro o peseta)");
            opcion = Console.ReadLine();

            if ((opcion == "euros") || (opcion == "euro"))
            {
                Console.WriteLine("Dime la cantidad en euros");
                e = double.Parse(Console.ReadLine());
                p = (e * 166.386);
                Console.WriteLine(p + "pesetas");

            }
            else
            {
                if ((opcion == "peseta") || (opcion == "pesetas"))
                {
                    Console.WriteLine("Dime la cantidad en pesetas");
                    p = double.Parse(Console.ReadLine());
                    e = (p / 166.386);
                    Console.WriteLine(e + "euros");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}