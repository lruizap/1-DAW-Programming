using System;

namespace _02_menú
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.Clear(); //Limpiar la pantalla 
            Console.WriteLine("Menú");
            Console.WriteLine("----");
            Console.WriteLine("1- EscribeArray5");
            Console.WriteLine("2- EscribeArray");
            Console.WriteLine("...");
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            opcion = int.Parse(Console.ReadLine());

            while (opcion != 1 || opcion !=2 || opcion != 0) // no se hacerlo xd 
            {
                Console.Clear(); //Limpiar la pantalla 
                Console.WriteLine("Menú");
                Console.WriteLine("----");
                Console.WriteLine("1- EscribeArray5");
                Console.WriteLine("2- EscribeArray");
                Console.WriteLine("...");
                Console.WriteLine("0- Salir");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                opcion = int.Parse(Console.ReadLine());
            }

            switch(opcion)
            {
                case 1:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        // Escribearray5(a);
                    }
                    break;
                case 2:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
                        // Escribearray(a);
                    }
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
