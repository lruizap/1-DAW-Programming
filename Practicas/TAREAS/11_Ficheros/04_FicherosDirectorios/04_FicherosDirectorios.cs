using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04_FicherosDirectorios
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
                Console.WriteLine("║1- CuantosFicheros                       ║");
                Console.WriteLine("║2- CuantosFicherosPro                    ║");
                Console.WriteLine("║3- CreaBackup                            ║");
                Console.WriteLine("║4- RenombraMasivo                        ║");
                Console.WriteLine("║5- CuentaLineasFicheros                  ║");
                Console.WriteLine("║6- FicheroMasGrande                      ║");
                Console.WriteLine("║7- ClasificaFicheros                     ║");
                Console.WriteLine("║8- ClasificaFicherosLista                ║");
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
                            Console.Clear();
                            Console.WriteLine("Dime la extensión del elemento");
                            string ext = Console.ReadLine();
                            Console.WriteLine("Hay un total de : " + CuantosFicheros(ext) + " ficheros " + ext + " en el directorio actual");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Dime la extensión del archivo");
                            string ext = Console.ReadLine();
                            string urlcarpeta = "H:/PRG/Practicas/TAREAS/11_Ficheros/04_FicherosDirectorios/04_FicherosDirectorios/bin/Debug/netcoreapp3.1";
                            Console.WriteLine("Hay un total de : " + CuantosFicherosPro(ext, urlcarpeta) + " ficheros " + ext + " en el directorio actual");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Dime el nombre del archivo");
                            string name = Console.ReadLine();
                            CreaBackup(name);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Dime la extensión que quieres cambiar");
                            string ext = Console.ReadLine();
                            Console.WriteLine("Dime la extensión por la que los vas a cambiar");
                            string ext2 = Console.ReadLine();
                            RenombraMasivo(ext, ext2);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Dime el nombre del fichero");
                            string ext = Console.ReadLine();
                            Console.WriteLine(CuentaLineasFicheros(ext));
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine(FicheroMasGrande());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            string urlcarpeta = "H:/PRG/Practicas/TAREAS/11_Ficheros/04_FicherosDirectorios/04_FicherosDirectorios/bin/Debug/netcoreapp3.1";
                            ClasificaFicheros(urlcarpeta);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 8:
                        {
                            Console.Clear();
                            ClasificaFicherosLista();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    case 9:
                        {
                            Console.Clear();
                            Mp3Shuffle();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║Pulse cualquier tecla para continuar║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("╔══════════════════════════════════╗");
                        Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                        Console.WriteLine("╚══════════════════════════════════╝");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void Mp3Shuffle()
        {
            string[] ficheros = Directory.GetFiles(".");
            List<string> lista = new List<string>();

            for (int i = 0; i < ficheros.Length; i++)
            {
                if (Path.GetExtension(ficheros[i]) == ".mp3")
                {
                    lista.Add(ficheros[i]);
                }
            }

            DesordenaLista(lista);

            int n = 1;
            foreach (string f in lista)
            {
                Console.WriteLine(f);
                string f2 = n.ToString().PadLeft(2, '0') + ". " + f;
                File.Move(f, f2);
                n++;
            }
        }

        static void DesordenaLista(List<string> l)
        {
            Random r = new Random();
            List<string> l2 = new List<string>();

            while (l.Count > 0)
            {
                int pos = r.Next(l.Count);
                l2.Add(l[pos]);
                l.RemoveAt(pos);
            }
            l.AddRange(l2);
        }

        static void ClasificaFicherosLista()
        {
            string[] ficheros = Directory.GetFiles(".");

            List<string> lext = new List<string>();
            List<int> lrep = new List<int>();

            for (int i = 0; i < ficheros.Length; i++)
            {
                string extension = Path.GetExtension(ficheros[i]);

                if (lext.Contains(extension))
                {
                    int pos = lext.IndexOf(extension);
                    lrep[pos]++;
                }
                else
                {
                    lext.Add(extension);
                    lrep.Add(1);
                }
            }

            while (lext.Count > 0)
            {
                int max = lrep.Max();
                int pos = lrep.IndexOf(max);

                Console.WriteLine(lext[pos] + "=>" + lrep[pos]);

                lext.RemoveAt(pos);
                lrep.RemoveAt(pos);
            }

        }
        
        static void ClasificaFicheros(string urlcarpeta)
        {
            int i, j = 0;

            string ext;
            Dictionary<string, int> ClasificaFicheros = new Dictionary<string, int>();
            string[] extension = Directory.GetFiles(urlcarpeta);

            for (i = 0; i < extension.Length; i++)
            {
                ext = Path.GetExtension(extension[i]);

                if (ClasificaFicheros.ContainsKey(ext))
                {
                    ClasificaFicheros[ext]++;
                }
                else
                {
                    ClasificaFicheros[ext] = 1;
                }

                //if (!ClasificaFicheros.TryAdd(ext, 1))
                //{
                //    ClasificaFicheros[ext]++;
                //}
            }

            foreach (KeyValuePair<string, int> p in ClasificaFicheros)
            {
                Console.WriteLine(p.Key + "-" + p.Value);
            }

        }

        static string FicheroMasGrande()
        {
            string resultado = "";
            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            int tam, max = 0;
            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                tam = (int)f.Length;
                if (tam > max)
                {
                    max = tam;
                    resultado = f.Name;
                }
            }

            return resultado;
        }

        static int CuentaLineasFicheros(string name)
        {
            int line= 0;
            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                if (f.Extension == name)
                {
                    line = line + File.ReadAllLines(ficheros[i]).Length;
                }
            }
            return line;
        }

        static void RenombraMasivo(string ext, string ext2)
        {
            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            for (int i = 0; i < ficheros.Length; i++)
            {
                string nombre1 = ficheros[i];
                string nombre2 = nombre1.Replace(ext, ext2);
                File.Move(nombre1, nombre2);
            }
        }

        static void CreaBackup(string name1)
        {
            string name2 = name1 + ".bak";
            if (File.Exists(name1))
            {
                while (File.Exists(name2))
                {
                    name2 = name2 + ".bak";
                }
                File.Copy(name1, name2);
            }
        }

        static int CuantosFicherosPro(string ext, string urlcarpeta)
        {
            string[] ficheros = Directory.GetFiles(urlcarpeta);
            int j = 0;
            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                if (f.Extension == ext)
                {
                    j++;
                }
            }
            return j;
        }

        static int CuantosFicheros(string v)
        {
            string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            int j = 0;
            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                if (f.Extension == v)
                {
                    j++;
                }
            }
            return j;
        }
    }
}
