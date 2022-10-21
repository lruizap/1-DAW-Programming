using System;

namespace Cambio_Grados
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            string opcion;

            Console.WriteLine("¿Qué grados quieres convertir?(centígrados/farenheit) ");
            opcion = Console.ReadLine();

            if((opcion == "centigrados") || (opcion == "centígrados"))  // (||) una u otra 
            {
                Console.WriteLine("Dime los grados centígrados");
                c = double.Parse(Console.ReadLine());
                f = ((c * 9.0) / 5.0) + 32;
                Console.WriteLine(f + " grados farenheit");
            }
            else
            {
                Console.WriteLine("Dime los grados farenheit");
                f = double.Parse(Console.ReadLine());
                c = ((f - 32) * 5.0) / 9.0;
                Console.WriteLine(c + " grados cetígrados");
            }


        }
    }
}
