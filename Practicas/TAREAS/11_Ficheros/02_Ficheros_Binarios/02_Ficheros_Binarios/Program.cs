using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _02_Ficheros_Binarios
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
            Console.WriteLine("║11- EscribeFichero1_100                  ║");
            Console.WriteLine("║12- LeeFicheroInt100                     ║");
            Console.WriteLine("║13- EscribeFicheroIntAleatorio           ║");
            Console.WriteLine("║14- EscribeFicheroIntAleatorioPro        ║");
            Console.WriteLine("║15- LeeFicheroInt                        ║");
            Console.WriteLine("║16- SumaFicheroInt                       ║");
            Console.WriteLine("║17- LeeFicheroIntLista                   ║");
            Console.WriteLine("║18- EscribeFicheroIntLista               ║");
            Console.WriteLine("║19- OrdenaFicheroInt                     ║");
            Console.WriteLine("║20- SeparaFicheroInt                     ║");
            Console.WriteLine("║21- InvierteFicheroInt                   ║");
            Console.WriteLine("║22- LeeColorinesConsola                  ║");
            Console.WriteLine("║   ...                                   ║");
            Console.WriteLine("║0- Salir                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            relacion = int.Parse(Console.ReadLine());

            while (relacion < 11 || relacion > 22)
            {
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║11- EscribeFichero1_100                  ║");
                Console.WriteLine("║12- LeeFicheroInt100                     ║");
                Console.WriteLine("║13- EscribeFicheroIntAleatorio           ║");
                Console.WriteLine("║14- EscribeFicheroIntAleatorioPro        ║");
                Console.WriteLine("║15- LeeFicheroInt                        ║");
                Console.WriteLine("║16- SumaFicheroInt                       ║");
                Console.WriteLine("║17- LeeFicheroIntLista                   ║");
                Console.WriteLine("║18- EscribeFicheroIntLista               ║");
                Console.WriteLine("║19- OrdenaFicheroInt                     ║");
                Console.WriteLine("║20- SeparaFicheroInt                     ║");
                Console.WriteLine("║21- InvierteFicheroInt                   ║");
                Console.WriteLine("║22- LeeColorinesConsola                  ║");
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
                case 11:
                    {
                        Console.Clear();
                        EscribeFichero1_100("EscribeFichero1_100.bin");
                    }
                    break;
                case 12:
                    {
                        Console.Clear();
                        LeeFicheroInt100("EscribeFichero1_100.bin");
                    }
                    break;
                case 13:
                    {
                        Console.Clear();
                        Console.WriteLine("¿Cuántos números quieres generar?");
                        int n = int.Parse(Console.ReadLine());
                        EscribeFicheroIntAleatorio("EscribeFicheroIntAleatorio.bin", n);
                    }
                    break;
                case 14:
                    {
                        Console.Clear();
                        int n, n2, n3;
                        Console.WriteLine("Dime el número de valores que se van a generar");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el valor mínimo");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el valor máximo");
                        n3 = int.Parse(Console.ReadLine());
                        while (n2 > n3)
                        {
                            Console.WriteLine("Error, intentalo con otros números");
                            Console.WriteLine("Dime el número de valores que se van a generar");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dime el valor mínimo");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dime el valor máximo");
                            n3 = int.Parse(Console.ReadLine());
                        }
                        EscribeFicheroIntAleatorioPro("EscribeFicheroIntAleatorioPro.bin", n, n2, n3);
                    }
                    break;
                case 15:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres leer");
                        string f = Console.ReadLine();
                        LeeFicheroInt(f);
                    }
                    break;
                case 16:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el nombre del fichero que quieres leer");
                        string f = Console.ReadLine();
                        Console.WriteLine(SumaFicheroInt(f));
                    }
                    break;
                case 17:
                    {
                        Console.Clear();
                        EscribeLista(LeeFicheroIntLista("EscribeFichero1_100.bin"));
                    }
                    break;
                case 18:
                    {
                        Console.Clear();
                        List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
                        EscribeFicheroIntLista("EscribeFicheroIntLista.bin", l);
                        LeeFicheroInt("EscribeFicheroIntLista.bin");
                    }
                    break;
                case 19:
                    {
                        Console.Clear();
                        List<int> l = new List<int> { 0,4,7,8,23,4567,1345345,3 };
                        EscribeFicheroIntLista("OrdenaFicheroInt.bin", l);
                        OrdenaFicheroInt("OrdenaFicheroInt.bin");
                        LeeFicheroInt("OrdenaFicheroInt.bin");

                    }
                    break;
                case 20:
                    {
                        Console.Clear();
                        SeparaFicheroInt("EscribeFicheroIntAleatorioPro.bin");
                        Console.WriteLine("Números positivos");
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.binpositivos");
                        Console.WriteLine();
                        Console.WriteLine("Números negativos");
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.binnegativos");
                    }
                    break;
                case 21:
                    {
                        InvierteFicheroInt("EscribeFichero1_100.bin");
                        LeeFicheroInt("EscribeFichero1_100.bin");
                    }
                    break;
                case 22:
                    {
                        LeeColorinesConsola("colorines1.color");
                        Console.WriteLine();
                        LeeColorinesConsola("colorines2.color");
                        Console.WriteLine();
                        LeeColorinesConsola("colorines3.color");
                        Console.WriteLine();
                        LeeColorinesConsola("colorines4.color");
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

        static void LeeColorinesConsola(string v)
        {
            FileStream fs = new FileStream(v, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int i, j;

            ConsoleColor original = Console.BackgroundColor;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    int n = br.ReadInt32();
                    Console.BackgroundColor = (ConsoleColor)n;
                    Console.Write("  ");
                }
                Console.BackgroundColor = original;
                Console.WriteLine();
            }

            br.Close();
            fs.Close();
        }

        static void InvierteFicheroInt(string filename)
        {
            List<int> l = LeeFicheroIntLista(filename);
            l.Reverse();
            EscribeFicheroIntLista(filename, l);
        }

        static void SeparaFicheroInt(string v)
        {
            FileStream fs = new FileStream(v, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> ln = new List<int>();
            List<int> lp = new List<int>();

            while (fs.Position < fs.Length)
            {
                int n = br.ReadInt32();

                if (n < 0)
                {
                    ln.Add(n);
                }
                else
                {
                    lp.Add(n);
                }
            }

            br.Close();
            fs.Close();

            EscribeFicheroIntLista(v + "positivos ", lp);
            EscribeFicheroIntLista(v + "negativos ", ln);
        }

        static void OrdenaFicheroInt(string v)
        {
            List<int> l = LeeFicheroIntLista(v);
            l.Sort();
            EscribeFicheroIntLista(v, l);
        }

        static void OrdenaListaPalabras(List<string> l)
        {
            //l.Sort();

            string min;
            List<string> l2 = new List<string>();
            string[] c = l.ToArray();
            while (l.Count > 0)
            {
                min = l.Min();
                l2.Add(min);
                l.Remove(min);
            }
            l.AddRange(l2);

        }

        static void EscribeFicheroIntLista(string v, List<int> l)
        {
            FileStream fs = new FileStream(v, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }

            bw.Close();
            fs.Close();
        }

        static void EscribeLista(List<int> l)
        {
            int i;
            if (l.Count > 0)
            {
                Console.Write("< ");
                for (i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }
                Console.WriteLine(l[l.Count - 1] + " >");
            }
            else
            {
                Console.WriteLine("<>");
            }
        }

        static List<int> LeeFicheroIntLista(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> l = new List<int>();

            while (fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();
            return l;
        }

        static int SumaFicheroInt(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int suma = 0;
            while (fs.Position < fs.Length)
            {
                suma += br.ReadInt32();
            }

            fs.Close();
            br.Close();

            return suma;
        }

        static void LeeFicheroInt(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Console.WriteLine(br.ReadInt32());
            }

            fs.Close();
            br.Close();
        }

        static void EscribeFicheroIntAleatorioPro(string v, int n, int n2, int n3)
        {
            FileStream fs = new FileStream("EscribeFicheroIntAleatorioPro.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Random r = new Random();

            for (int i = 0; i < n ; i++)
            {
                bw.Write(r.Next(n2, n3 + 1));
            }

            bw.Close();
            fs.Close();
        }

        static void EscribeFicheroIntAleatorio(string v, int n)
        {
            FileStream fs = new FileStream("EscribeFicheroIntAleatorio.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                bw.Write(r.Next(1, 100 + 1));
            }

            bw.Close();
            fs.Close();

        }

        static void LeeFicheroInt100(string v)
        {
            FileStream fs = new FileStream("EscribeFichero1_100.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Console.WriteLine(br.ReadInt32()); 
            }

            fs.Close();
            br.Close();

        }

        static void EscribeFichero1_100(string v)
        {
            FileStream fs = new FileStream("EscribeFichero1_100.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i <= 100; i++)
            {
                bw.Write(i);
            }

            fs.Close();
            bw.Close();
        }
    }
}
