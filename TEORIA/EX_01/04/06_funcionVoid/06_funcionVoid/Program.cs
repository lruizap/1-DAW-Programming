using System;

namespace _06_funcionVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            EscribeSeparador120();
            Console.WriteLine("Esta función escribe un separador");
            EscribeSeparador(40);
            Console.WriteLine("Para que quede bonita la cosa");
        }

        static void EscribeSeparador120()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }

        static void EscribeSeparador(int numeroguiones)
        {
            int i;
            for (i = 0; i < numeroguiones; i++)
            {
                Console.Write("-"); //Para escribir todo en la misma linea quitar el Line al cw
            }
            Console.WriteLine();
        }



    }
}
