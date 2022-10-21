using System;
using System.IO;

namespace _09_Venta_de_Coches
{
    class Program
    {
        static void Main(string[] args)
        {
            int relacion = -1;
            
            Console.WriteLine("Dime el nombre del fichero que quieres cargar");
            string fichero = Console.ReadLine();
            // Quitar cuando quiera modificar el fichero por defecto
            string ficheroPred = "Coches2.csv";
            AutoVenta.CargaCSV(ficheroPred);
            bool modificado = false;

            while (relacion != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige el ejercicio                │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1- Crea Coche                            ║");
                Console.WriteLine("║2- Busca Coche                           ║");
                Console.WriteLine("║3- Imprime Listado                       ║");
                Console.WriteLine("║4- Añade coches                          ║");
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
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Dime la matrícula del coche (4 números y 3 letras)");
                            string s = Console.ReadLine();
                            Console.WriteLine("Dime la fecha de matriculación");
                            DateTime d = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Dime la marca del coche");
                            string m = Console.ReadLine();
                            Console.WriteLine("Dime el modelo del coche");
                            string mod = Console.ReadLine();
                            Console.WriteLine("Dime el precio del coche");
                            double prec = double.Parse(Console.ReadLine());
                            Coche c = new Coche(s, d, m, mod, prec);
                            Console.WriteLine(c.ToString());

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine();
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Dime la matrícula del coche");
                            string s = Console.ReadLine();
                            Console.WriteLine(AutoVenta.BuscaCoche(s));

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine();
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(AutoVenta.ImprimeListado());

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine();
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            Console.WriteLine("Dime la matrícula del coche (4 números y 3 letras)");
                            string s = Console.ReadLine();
                            Console.WriteLine("Dime la fecha de matriculación");
                            DateTime d = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Dime la marca del coche");
                            string m = Console.ReadLine();
                            Console.WriteLine("Dime el modelo del coche");
                            string mod = Console.ReadLine();
                            Console.WriteLine("Dime el precio del coche");
                            double prec = double.Parse(Console.ReadLine());
                            Coche c = new Coche(s, d, m, mod, prec);
                            Console.WriteLine(c.ToString());

                            AutoVenta.InsertaCoche(c);
                            Console.WriteLine(AutoVenta.ImprimeListado());
                            modificado = true;

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine();
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine();
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║Pulse cualquier tecla para continuar║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        if (modificado)
                        {
                            AutoVenta.GuardaCSV(ficheroPred);
                        }
                        break;
                }
            }
        }
    }
}
