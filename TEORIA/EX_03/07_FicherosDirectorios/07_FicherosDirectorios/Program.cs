using System;
using System.IO;

namespace _07_FicherosDirectorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory.CreateDirectory("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata");
            // Directory.Delete("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata")
            // Directory.Move("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata", "H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Tomate")

            //if (Directory.Exists("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata/"))
            //{
            //    Console.WriteLine("La patata está en su sitio");
            //}

            if (File.Exists("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata_2/uno.txt"))
            {
                Console.WriteLine("El archivo está en su sitio");
            }

            //File.Move("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata/uno.txt", "H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata/unocopia.txt")
            //File.Delete("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata/uno.txt");

            string[] ficheros = Directory.GetFiles("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata_2");
            // Directory.GetDirectories("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata");

            string miCarpeta = Directory.GetCurrentDirectory();
            string[] ficher = Directory.GetFiles(miCarpeta);
            for (int i = 0; i < ficher.Length; i++)
            {
                Console.WriteLine(ficher[i]);
            }

            for (int i = 0; i < ficheros.Length; i++)
            {
                //string nombre1 = ficheros[i];
                //string nombre2 = nombre1.Replace(" ", "_");
                //File.Move(nombre1, nombre2);

                //string nombre1 = ficheros[i];

                //Console.WriteLine(Path.GetDirectoryName(nombre1));
                //Console.WriteLine(Path.GetFileName(nombre1));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(nombre1));
                //Console.WriteLine(Path.GetExtension(nombre1));

                //if (nombre1.Contains("_"))
                //{
                //    string nombre2 = nombre1.Replace("_", " ");
                //    File.Move(nombre1, nombre2);
                //}

                //string nombre1 = Path.GetFileName(ficheros[i]);
                //if (nombre1.Contains("_"))
                //{
                //    string nombre2 = nombre1.Replace("_", " ");

                //    nombre1 = Path.GetDirectoryName(ficheros[i]) + "\\" + nombre1;
                //    nombre2 = Path.GetDirectoryName(ficheros[i]) + "\\" + nombre2;

                //    Console.WriteLine("nombre1 = " + nombre1);
                //    Console.WriteLine("nombre2 = " + nombre2);

                //    File.Move(nombre1, nombre2);
                //}

                FileInfo f = new FileInfo("H:/PRG/Practicas/TEORIA/EX_03/07_FicherosDirectorios/Patata/uno.txt");
                Console.WriteLine(f.FullName);
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Length);
                Console.WriteLine(f.DirectoryName);
                Console.WriteLine(f.CreationTime);
                Console.WriteLine(f.Exists);
                Console.WriteLine(f.Extension);
                Console.WriteLine(f.IsReadOnly);
            }
        }
    }
}
