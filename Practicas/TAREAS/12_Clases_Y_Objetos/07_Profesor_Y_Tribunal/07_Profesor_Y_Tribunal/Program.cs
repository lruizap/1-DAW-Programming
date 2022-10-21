using System;

namespace _07_Profesor_Y_Tribunal
{
    class Program
    {
        static void Main(string[] args)
        {
            int relacion = -1;

            while (relacion != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1- Crea Un Profesor                      ║");
                Console.WriteLine("║2- Lee Fichero                           ║");
                Console.WriteLine("║   ...                                   ║");
                Console.WriteLine("║0- Salir                                 ║");
                Console.WriteLine("╚═════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                relacion = int.Parse(Console.ReadLine());


                switch (relacion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Dime el nombre");
                            string s = Console.ReadLine();
                            Console.WriteLine("Dime el DNI");
                            string d = Console.ReadLine();
                            Console.WriteLine("Dime el género");
                            int g = int.Parse(Console.ReadLine());
                            Profesor p = new Profesor(s,d,(TipoGenero)g);
                            Console.WriteLine(p.ToString());
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Tribunal t = new Tribunal("profesores1csharp.bin");
                            t.EligeTribunal();
                            Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}
