using System;
using System.Collections.Generic;
using System.IO;

namespace _03_FicherosRegistro
{
    class Program
    {

        public class FichaAlumno
        {
            public string nombre;
            public int edad;
            public double calificacion;

         }

        static void Main(string[] args)
        {
            List<FichaAlumno> listaAlumnos = new List<FichaAlumno>();

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
                Console.WriteLine("║1- LeeAlumnoLista                        ║");
                Console.WriteLine("║2- ImprimeListaAlumnos                   ║");
                Console.WriteLine("║3- EscribeFicheroAlumnosBinario          ║");
                Console.WriteLine("║4- LeeFicheroAlumnosBinario              ║");
                Console.WriteLine("║5- EscribeFicheroAlumnosTexto            ║");
                Console.WriteLine("║6- LeeFicheroAlumnosTexto                ║");
                Console.WriteLine("║7- EscribeFicheroAlumnosCSV              ║");
                Console.WriteLine("║8- LeeFicheroAlumnosCSV                  ║");
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
                            LeeAlumnoLista(listaAlumnos);
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
                            ImprimeListaAlumnos(listaAlumnos);
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
                            EscribeFicheroAlumnosBinario(listaAlumnos, "EscribeFicheroAlumnosBinario.bin");
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
                            LeeFicheroAlumnosBinario(listaAlumnos, "EscribeFicheroAlumnosBinario.bin");
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
                            EscribeFicheroAlumnosTexto(listaAlumnos, "EscribeFicheroAlumnosTexto.txt");
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
                            LeeFicheroAlumnosTexto(listaAlumnos, "EscribeFicheroAlumnosTexto.txt");
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
                            EscribeFicheroAlumnosCSV(listaAlumnos, "EscribeFicheroAlumnosCSV.csv");
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
                            LeeFicheroAlumnosCSV(listaAlumnos, "EscribeFicheroAlumnosCSV.csv");
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

        static void LeeFicheroAlumnosCSV(List<FichaAlumno> listaAlumnos, string v)
        {
            StreamReader sr = new StreamReader(v);
            string[] s;

            while (!sr.EndOfStream)
            {
                FichaAlumno alumno = new FichaAlumno();
                s = sr.ReadLine().Split(";");

                Console.WriteLine(alumno.nombre = s[0]);
                Console.WriteLine(alumno.edad = int.Parse(s[1]));
                Console.WriteLine(alumno.calificacion = double.Parse(s[2]));

                listaAlumnos.Add(alumno);
            }

            sr.Close();
        }

        static void EscribeFicheroAlumnosCSV(List<FichaAlumno> listaAlumnos, string v)
        {
            StreamWriter sw = new StreamWriter(v);
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].nombre + ";" + listaAlumnos[i].edad + ";" + listaAlumnos[i].calificacion);
            }

            sw.Close();
        }

        static void LeeFicheroAlumnosTexto(List<FichaAlumno> listaAlumnos, string v)
        {
            listaAlumnos.Clear();
            StreamReader sr = new StreamReader(v);
            int numeroregistro = int.Parse(sr.ReadLine());
            for (int i = 0; i < numeroregistro; i++)
            {
                FichaAlumno f2 = new FichaAlumno();
                f2.nombre = sr.ReadLine();
                f2.edad = int.Parse(sr.ReadLine());
                f2.calificacion = int.Parse(sr.ReadLine());

                listaAlumnos.Add(f2);
            }
            sr.Close();
        }

        static void EscribeFicheroAlumnosTexto(List<FichaAlumno> listaAlumnos, string v)
        {
            StreamWriter sw = new StreamWriter(v);
            sw.WriteLine(listaAlumnos.Count);
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].nombre);
                sw.WriteLine(listaAlumnos[i].edad);
                sw.WriteLine(listaAlumnos[i].calificacion);
            }

            sw.Close();
        }

        static void LeeFicheroAlumnosBinario(List<FichaAlumno> listaAlumnos, string v)
        {
            listaAlumnos.Clear();
            FileStream fs = new FileStream(v, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            br.ReadInt32();
            while (fs.Position < fs.Length)
            {
                FichaAlumno f2 = new FichaAlumno();
                f2.nombre = br.ReadString();
                f2.edad = br.ReadInt32();
                f2.calificacion = br.ReadDouble();

                listaAlumnos.Add(f2);
            }

            br.Close();
            fs.Close();
        }

        static void EscribeFicheroAlumnosBinario(List<FichaAlumno> l, string v)
        {
            FileStream fs = new FileStream("EscribeFicheroAlumnosBinario.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(i);
                bw.Write(l[i].nombre);
                bw.Write(l[i].edad);
                bw.Write(l[i].calificacion);
            }

            fs.Close();
            bw.Close();
        }

        static void LeeAlumnoLista(List <FichaAlumno> l)
        {
            FichaAlumno f = new FichaAlumno();
            Console.WriteLine("Dime el nombre del alumno");
            f.nombre = Console.ReadLine();
            Console.WriteLine("Dime la edad del alumno");
            f.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime la calificación del alumno");
            f.calificacion = double.Parse(Console.ReadLine());

            l.Add(f);
        }

        static void ImprimeListaAlumnos(List <FichaAlumno> l)
        {
            Console.WriteLine("   Nombre".PadRight(30) + "Edad".PadRight(7) + "Calificación".PadRight(15));
            Console.WriteLine("===========================".PadRight(30) + "====".PadRight(7) + "============".PadRight(15));
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(i+1 + ": " + l[i].nombre.PadRight(25) + l[i].edad.ToString().PadLeft(6) + l[i].calificacion.ToString().PadLeft(15));
            }
        }
    }
}
