using System;

namespace _08_Hora
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
                Console.WriteLine("║ │   Elige el ejercicio                │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1- Hora                                  ║");
                Console.WriteLine("║2- Cuentas Horas                         ║");
                Console.WriteLine("║3-                       ║");
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
                            int opcion = -1;
                            while (opcion != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Clear();
                                Console.WriteLine("╔════╗");
                                Console.WriteLine("║Menú║");
                                Console.WriteLine("╚════╝");
                                Console.WriteLine("╔═════════════════════════════════════════╗");
                                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                                Console.WriteLine("║ │   Elige el ejercicio                │ ║");
                                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                                Console.WriteLine("║1- Hora en segundos                      ║");
                                Console.WriteLine("║2- HH:MM:SS                              ║");
                                Console.WriteLine("║   ...                                   ║");
                                Console.WriteLine("║0- Salir                                 ║");
                                Console.WriteLine("╚═════════════════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("Elige una opción : ");
                                opcion = int.Parse(Console.ReadLine());
                                switch (opcion)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Dime los segundos");
                                            int s = int.Parse(Console.ReadLine());
                                            Hora h = new Hora(s);
                                            Console.WriteLine(h.ToString());

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
                                            Console.WriteLine("Dime las horas");
                                            int H = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime los minutos");
                                            int M = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime los segundos");
                                            int S = int.Parse(Console.ReadLine());
                                            Hora h = new Hora(H, M, S);
                                            Console.WriteLine(h.ToString());

                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine();
                                            Console.WriteLine("╔════════════════════════════════════╗");
                                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                                            Console.WriteLine("╚════════════════════════════════════╝");
                                            Console.ReadLine();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            int opcion = -1;
                            while (opcion != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Clear();
                                Console.WriteLine("╔════╗");
                                Console.WriteLine("║Menú║");
                                Console.WriteLine("╚════╝");
                                Console.WriteLine("╔═════════════════════════════════════════╗");
                                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                                Console.WriteLine("║ │   Elige el ejercicio                │ ║");
                                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                                Console.WriteLine("║1- Suma Horas                            ║");
                                Console.WriteLine("║2- Resta Horas                           ║");
                                Console.WriteLine("║   ...                                   ║");
                                Console.WriteLine("║0- Salir                                 ║");
                                Console.WriteLine("╚═════════════════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("Elige una opción : ");
                                opcion = int.Parse(Console.ReadLine());
                            }
                            switch (opcion)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Dime los segundos");
                                        int s = int.Parse(Console.ReadLine());
                                        Hora h = new Hora(s);
                                        Console.WriteLine("Dime los segundos");
                                        int s2 = int.Parse(Console.ReadLine());
                                        Hora h2 = new Hora(s);
                                        Console.WriteLine(h.ToString());
                                        Console.WriteLine(h.ToString());
                                        Console.WriteLine((h+h2).ToString());

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
                                        Console.WriteLine("Dime los segundos");
                                        int s = int.Parse(Console.ReadLine());
                                        Hora h = new Hora(s);
                                        Console.WriteLine("Dime los segundos");
                                        int s2 = int.Parse(Console.ReadLine());
                                        Hora h2 = new Hora(s);
                                        Console.WriteLine(h.ToString());
                                        Console.WriteLine(h.ToString());
                                        Console.WriteLine((h - h2).ToString());

                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine();
                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║Pulse cualquier tecla para continuar║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.ReadLine();
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine();
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║Pulse cualquier tecla para continuar║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
