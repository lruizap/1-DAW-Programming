using System;

namespace _06_Animales
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
                Console.WriteLine("║1- Añade un animal                       ║");
                Console.WriteLine("║2- Busca un animal                       ║");
                Console.WriteLine("║3- ListaVeterinaria                      ║");
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
                                Console.WriteLine("║ │   Elige el tipo de Animal           │ ║");
                                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                                Console.WriteLine("║1- Perro                                 ║");
                                Console.WriteLine("║2- Gato                                  ║");
                                Console.WriteLine("║3- Pajaro                                ║");
                                Console.WriteLine("║3- Reptil                                ║");
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
                                            Console.WriteLine("Escribe el nombre:");
                                            string nombre = Console.ReadLine();
                                            Console.WriteLine("Dime la raza");
                                            RazaPerro raz = EligeRazaPerro();
                                            Console.WriteLine("Escribe la fecha de nacimiento:");
                                            DateTime d = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el peso:");
                                            double peso = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el microship");
                                            string microship = Console.ReadLine();

                                            Perro p = new Perro(nombre, raz, d, peso, microship);
                                            Console.WriteLine(p.ToString());

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
                                            Console.WriteLine("Escribe el nombre:");
                                            string nombre = Console.ReadLine();
                                            Console.WriteLine("Dime la raza");
                                            RazaGato raz = EligeRazaGato();
                                            Console.WriteLine("Escribe la fecha de nacimiento:");
                                            DateTime d = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el peso:");
                                            double peso = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el microship");
                                            string microship = Console.ReadLine();

                                            Gato p = new Gato(nombre, raz, d, peso, microship);
                                            Console.WriteLine(p.ToString());

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
                                            Console.WriteLine("Escribe el nombre:");
                                            string nombre = Console.ReadLine();
                                            Console.WriteLine("Dime la raza");
                                            EspeciePajaro raz = EligeEspeciePajaro();
                                            Console.WriteLine("Escribe la fecha de nacimiento:");
                                            DateTime d = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el peso:");
                                            double peso = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime si es cantor (1 si, el resto no)");
                                            bool cantor;
                                            int i = int.Parse(Console.ReadLine());
                                            if (i == 1)
                                            {
                                                cantor = true;
                                            }
                                            else
                                            {
                                                cantor = false;
                                            }

                                            Pajaro p = new Pajaro(nombre, raz, d, peso, cantor);
                                            Console.WriteLine(p.ToString());

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
                                            Console.WriteLine("Escribe el nombre:");
                                            string nombre = Console.ReadLine();
                                            Console.WriteLine("Dime la raza");
                                            EspeciePajaro raz = EligeEspeciePajaro();
                                            Console.WriteLine("Escribe la fecha de nacimiento:");
                                            DateTime d = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime el peso:");
                                            double peso = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Dime si es venenoso (1 si, el resto no)");
                                            bool venenoso;
                                            int i = int.Parse(Console.ReadLine());
                                            if (i == 1)
                                            {
                                                venenoso = true;
                                            }
                                            else
                                            {
                                                venenoso = false;
                                            }

                                            Pajaro p = new Pajaro(nombre, raz, d, peso, venenoso);
                                            Console.WriteLine(p.ToString());

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
                            Console.WriteLine("Escribe el nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine(ClinicaVeterinaria.BuscaAnimal(nombre).ToString());


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

        public static RazaPerro EligeRazaPerro()
        {
            string[] raz = Enum.GetNames(typeof(RazaPerro));
            for (int i = 0; i < raz.Length; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("- " + raz[i].Replace('_', ' '));
            }

            Console.Write("Opción: ");
            int op = int.Parse(Console.ReadLine());

            return (RazaPerro)(op - 1);
        }

        public static RazaGato EligeRazaGato()
        {
            string[] raz = Enum.GetNames(typeof(RazaGato));
            for (int i = 0; i < raz.Length; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("- " + raz[i].Replace('_', ' '));
            }

            Console.Write("Opción: ");
            int op = int.Parse(Console.ReadLine());

            return (RazaGato)(op - 1);
        }

        public static EspeciePajaro EligeEspeciePajaro()
        {
            string[] raz = Enum.GetNames(typeof(EspeciePajaro));
            for (int i = 0; i < raz.Length; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("- " + raz[i].Replace('_', ' '));
            }

            Console.Write("Opción: ");
            int op = int.Parse(Console.ReadLine());

            return (EspeciePajaro)(op - 1);
        }

        public static EspecieReptil EligeEspecieReptil()
        {
            string[] raz = Enum.GetNames(typeof(EspecieReptil));
            for (int i = 0; i < raz.Length; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("- " + raz[i].Replace('_', ' '));
            }

            Console.Write("Opción: ");
            int op = int.Parse(Console.ReadLine());

            return (EspecieReptil)(op - 1);
        }
    }
}
