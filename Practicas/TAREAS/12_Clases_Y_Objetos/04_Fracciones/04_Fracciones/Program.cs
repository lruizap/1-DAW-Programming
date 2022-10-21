using System;

namespace _04_Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Menú_1
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
                Console.WriteLine("║1- Dibuja Fracción --> ToString()        ║");
                Console.WriteLine("║2- Simplificar                           ║");
                Console.WriteLine("║3- Opera Fracciones                      ║");
                Console.WriteLine("║   ...                                   ║");
                Console.WriteLine("║0- Salir                                 ║");
                Console.WriteLine("╚═════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                relacion = int.Parse(Console.ReadLine());

                #endregion


                switch (relacion)
                {
                    case 1:
                        {
                            int fraccion = -1;
                            while (fraccion != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("╔════╗");
                                Console.WriteLine("║Menú║");
                                Console.WriteLine("╚════╝");
                                Console.WriteLine("╔═════════════════════════════════════════╗");
                                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                                Console.WriteLine("║ │   Elige el tipo de fracción         │ ║");
                                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                                Console.WriteLine("║1- int        (n, n2)                    ║");
                                Console.WriteLine("║2- int        (n)                        ║");
                                Console.WriteLine("║3- double     (n)                        ║");
                                Console.WriteLine("║   ...                                   ║");
                                Console.WriteLine("║0- Salir                                 ║");
                                Console.WriteLine("╚═════════════════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("Elige una opción : ");
                                fraccion = int.Parse(Console.ReadLine());

                                switch (fraccion)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            int n, n2;
                                            Console.WriteLine("Dime el valor del numerador");
                                            n = int.Parse(Console.ReadLine());
                                            while (n == 0)
                                            {
                                                Console.WriteLine("Escribe un numerador válido");
                                                n = int.Parse(Console.ReadLine());
                                            }
                                            Console.WriteLine("Dime el valor del denominador");
                                            n2 = int.Parse(Console.ReadLine());
                                            while (n2 == 0)
                                            {
                                                Console.WriteLine("Escribe un numerador válido");
                                                n2 = int.Parse(Console.ReadLine());
                                            }
                                            Console.WriteLine();
                                            Fraccion f = new Fraccion(n, n2);
                                            Console.WriteLine(f.ToString());

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

                                            int n;
                                            Console.WriteLine("Dime el valor del numerador");
                                            n = int.Parse(Console.ReadLine());
                                            while (n == 0)
                                            {
                                                Console.WriteLine("Escribe un numerador válido");
                                                n = int.Parse(Console.ReadLine());
                                            }

                                            Console.WriteLine();
                                            Fraccion f = new Fraccion(n);
                                            Console.WriteLine(f.ToString());

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

                                            double n;
                                            Console.WriteLine("Dime el valor del numerador");
                                            n = double.Parse(Console.ReadLine());
                                            while (n == 0)
                                            {
                                                Console.WriteLine("Escribe un numerador válido");
                                                n = double.Parse(Console.ReadLine());
                                            }

                                            Console.WriteLine();
                                            Fraccion f = new Fraccion(n);
                                            Console.WriteLine(f.ToString());

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
                            int n, n2;
                            Console.WriteLine("Dime el numerador y denominador de la fracción (int)");
                            Console.WriteLine("Dime el numerador");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dime el denominador");
                            n2 = int.Parse(Console.ReadLine());
                            Fraccion f = new Fraccion(n, n2);
                            f.Simplificar();
                            Console.WriteLine(f.ToString());
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            int n, n2;
                            Console.WriteLine("Dime el valor del numerador");
                            n = int.Parse(Console.ReadLine());
                            while (n == 0)
                            {
                                Console.WriteLine("Escribe un numerador válido");
                                n = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Dime el valor del denominador");
                            n2 = int.Parse(Console.ReadLine());
                            while (n2 == 0)
                            {
                                Console.WriteLine("Escribe un numerador válido");
                                n2 = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine();

                            int n3, n4;
                            Console.WriteLine("Dime el valor del numerador");
                            n3 = int.Parse(Console.ReadLine());
                            while (n3 == 0)
                            {
                                Console.WriteLine("Escribe un numerador válido");
                                n3 = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Dime el valor del denominador");
                            n4 = int.Parse(Console.ReadLine());
                            while (n4 == 0)
                            {
                                Console.WriteLine("Escribe un numerador válido");
                                n4 = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine();

                            Fraccion f = new Fraccion(n, n2);
                            Fraccion f2 = new Fraccion(n3, n4);
                            Console.WriteLine(f.ToString());
                            Console.WriteLine(f2.ToString());

                            int operacion = -1;
                            while (operacion  != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("╔════╗");
                                Console.WriteLine("║Menú║");
                                Console.WriteLine("╚════╝");
                                Console.WriteLine("╔═════════════════════════════════════════╗");
                                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                                Console.WriteLine("║ │   Elige el tipo de fracción         │ ║");
                                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                                Console.WriteLine("║1- suma                                  ║");
                                Console.WriteLine("║2- resta                                 ║");
                                Console.WriteLine("║3- multiplica                            ║");
                                Console.WriteLine("║4- divide                                ║");
                                Console.WriteLine("║   ...                                   ║");
                                Console.WriteLine("║0- Salir                                 ║");
                                Console.WriteLine("╚═════════════════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("Elige una opción : ");
                                operacion = int.Parse(Console.ReadLine());

                                switch (operacion)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine((f + f2).ToString());

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
                                            if (f >= f2)
                                            {
                                                Console.WriteLine((f - f2).ToString());
                                            }
                                            else
                                            {
                                                Console.WriteLine((f2 - f).ToString());
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine((f * f2).ToString());
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine((f / f2).ToString());
                                        }
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine();
                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║Pulse cualquier tecla para continuar║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.WriteLine();
                                        break;
                                }
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
