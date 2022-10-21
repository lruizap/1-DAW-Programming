using System;
using System.IO;
using System.Collections.Generic;

namespace _01_Ficheros_De_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            #region Menú_1
            int relacion;

            Console.WriteLine("╔════╗");
            Console.WriteLine("║Menú║");
            Console.WriteLine("╚════╝");
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
            Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
            Console.WriteLine("║1- EscribeFicheroNumRandom10             ║");
            Console.WriteLine("║2- SumaFicheroInt10                      ║");
            Console.WriteLine("║3- EscribeFicheroNumRandom               ║");
            Console.WriteLine("║4- SumaFicheroInt                        ║");
            Console.WriteLine("║5- EscribeFicheroTexto                   ║");
            Console.WriteLine("║6- LeeFicheroTexto                       ║");
            Console.WriteLine("║7- CopiaFicheroTexto                     ║");
            Console.WriteLine("║8- InvierteLineasFichero                 ║");
            Console.WriteLine("║9- InvierteFicheroTexto                  ║");
            Console.WriteLine("║10- SeparaPalabrasFichero                ║");
            Console.WriteLine("║   ...                                   ║");
            Console.WriteLine("║0- Salir                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            relacion = int.Parse(Console.ReadLine());

            while (relacion < 0 || relacion > 10)
            {
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1- EscribeFicheroNumRandom10             ║");
                Console.WriteLine("║2- SumaFicheroInt10                      ║");
                Console.WriteLine("║3- EscribeFicheroNumRandom               ║");
                Console.WriteLine("║4- SumaFicheroInt                        ║");
                Console.WriteLine("║5- EscribeFicheroTexto                   ║");
                Console.WriteLine("║6- LeeFicheroTexto                       ║");
                Console.WriteLine("║7- CopiaFicheroTexto                     ║");
                Console.WriteLine("║8- InvierteLineasFichero                 ║");
                Console.WriteLine("║9- InvierteFicheroTexto                  ║");
                Console.WriteLine("║10- SeparaPalabrasFichero                ║");
                Console.WriteLine("║   ...                                   ║");
                Console.WriteLine("║0- Salir                                 ║");
                Console.WriteLine("╚═════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                relacion = int.Parse(Console.ReadLine());
            }

            #endregion

            switch (relacion)
            {
                case 1:
                    {
                        Console.Clear();
                        EscribeFicheroNumRandom10("EscribeFicheroNumRandom10.txt");
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("La suma de los datos es : " + SumaFicheroInt10("EscribeFicheroNumRandom10.txt"));
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime cuántos números quieres");
                        int n = int.Parse(Console.ReadLine());
                        EscribeFicheroNumRandom("EscribeFicheroNumRandom.txt", n);
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime cuántos números quieres");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de todos los números es : " + SumaFicheroInt("SumaFicheroInt.txt", n));
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        EscribeFicheroTexto("EscribeFicheroTexto.txt");
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres leer");
                        string f = Console.ReadLine();
                        LeeFicheroTexto(f);
                    }
                    break;
                case 7:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres copiar");
                        string f = Console.ReadLine();
                        CopiaFicheroTexto("CopiaFicheroTexto.txt", f);
                    }
                    break;
                case 8:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres Invertir");
                        string f = Console.ReadLine();
                        InvierteLineasFichero("InvierteLineasFichero.txt", f);

                    }
                    break;
                case 9:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres Invertir");
                        string f = Console.ReadLine();
                        InvierteFicheroTexto("InvierteFicheroTexto.txt", f);
                    }
                    break;
                case 10:
                    {
                        Console.Clear();
                        SeparaPalabrasFichero("SeparaPalabrasFichero.txt", "SeparaPalabrasFichero-separadas.txt");
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

        static void SeparaPalabrasFichero(string f1, string f2)
        {
            StreamReader sr = new StreamReader(f1);
            StreamWriter sw = new StreamWriter(f2);
            string[] s;

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Split(' ');

                for (int i = 0; i < s.Length; i++)
                {
                    sw.WriteLine(s[i]);
                }
            }

            sw.Close();
            sr.Close();
        }

        static void InvierteFicheroTexto(string v, string f)
        {
            List<string> s = StreamToList(f);
            StreamWriter sw = new StreamWriter(v);

            s.Reverse();

            for (int i = 0; i < s.Count; i++)
            {
                sw.WriteLine(s[i]);
            }

            sw.Close();
        }

        static List<string> StreamToList(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            List<string> l = new List<string>();

            while (!sr.EndOfStream)
            {
                l.Add(sr.ReadLine());
            }
            sr.Close();
            return l;
        }

        static void InvierteLineasFichero(string newf, string f)
        {
            StreamReader sr = new StreamReader(f);
            StreamWriter sw = new StreamWriter(newf);
            while (!sr.EndOfStream)
            {
                sw.WriteLine(InvierteCadena(sr.ReadLine()));
            }
            sw.Close();
            sr.Close();
        }

        static string InvierteCadena(string s)
        {
            string temp = "";
            for (int j = s.Length - 1; j >= 0; j--)
            {
                temp = temp + s[j];
            }

            s = temp;

            return s;
        }

        static void CopiaFicheroTexto(string nwfile, string name)
        {
            StreamReader sr = new StreamReader(name);
            StreamWriter sw = new StreamWriter(nwfile);

            while (!sr.EndOfStream)
            {
                sw.WriteLine(sr.ReadLine());
            }

            LeeFicheroTexto("EscribeFichero1_100.txt");

            sw.Close();
            sr.Close();
        }

        static void LeeFicheroTexto(string f)
        {
            StreamReader sr = new StreamReader(f);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        static void EscribeFicheroTexto(string v)
        {
            StreamWriter sw = new StreamWriter(v);
            string addtext = Console.ReadLine();
            while (addtext != "")
            {
                sw.WriteLine(addtext);
                addtext = Console.ReadLine();
            }

            sw.Close();
        }

        static int SumaFicheroInt(string v, int n)
        {
            StreamWriter sw = new StreamWriter(v);
            int i, suma = 0;
            for (i = 0; i < n; i++)
            {
                Random r = new Random();
                sw.WriteLine(r.Next(1, 10 + 1));
            }
            sw.Close();

            StreamReader sr = new StreamReader(v);

            while (!sr.EndOfStream)
            {
                suma += int.Parse(sr.ReadLine());
            }

            sr.Close();
            return suma;
        }

        static void EscribeFicheroNumRandom(string v, int n)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            StreamWriter sw = new StreamWriter(v);
            int i;
            for (i = 0; i < n; i++)
            {
                Random r = new Random();
                sw.WriteLine(r.Next(1, 10 + 1));
            }
            sw.Close();
        }

        static int SumaFicheroInt10(string v)
        {
            StreamReader sr = new StreamReader(v);
            int suma = 0;

            while (!sr.EndOfStream)
            {
                suma += int.Parse(sr.ReadLine());
            }

            sr.Close();
            return suma;
        }

        static void EscribeFicheroNumRandom10(string fichero)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            StreamWriter sw = new StreamWriter(fichero);
            int i, n;
            for (i = 0; i < 10; i++)
            {
                Random r = new Random();
                n = r.Next(1, 10 + 1);
                sw.WriteLine(n);
            }

            sw.Close();
        }
    }
}
