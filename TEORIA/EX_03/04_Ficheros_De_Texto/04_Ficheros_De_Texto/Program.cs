using System;
using System.IO;

namespace _04_Ficheros_De_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. abrimos un fichero para escritura = creamos un fichero nuevo
            //StreamWriter sw = new StreamWriter("prueba.txt");

            //// 2. escribir cosas en el fichero

            //sw.WriteLine("Hola Don Pepito, Hola don José");
            //sw.WriteLine("¿Pasó usted ya por casa?");

            //    // Pirámide de $
            //    int esp, asteriscos;

            //    for (int i = 1; i <= 10; i++) // me cuenta los saltos de linea
            //    {
            //        sw.WriteLine();
            //        for (esp = 0; esp < 10 - i; esp++) // me cuenta los espacios 
            //        {
            //            sw.Write(" ");
            //        }

            //        for (asteriscos = 0; asteriscos < (i * 2) - 1; asteriscos++)
            //        {
            //            sw.Write("$");
            //        }
            //    }

            //// 3. cerrar fichero

            //sw.Close();

            // 1. abrimos el fichero para lectura

            StreamReader sr = new StreamReader("prueba.txt");

            // 2. leemos cosas del fichero

            string l;

            //int i;

            //for (i = 0; i < 13; i++)  Para esto tenemos que saber cuántos elementos hay en el fichero.
            //{
            //    l = sr.ReadLine();
            //    Console.WriteLine(l);
            //}

            while (!sr.EndOfStream) // esto lee hasta que termina el fichero, por tanto, no necesitamos saber q hay dentro.
            {
                l = sr.ReadLine();
                Console.WriteLine(l);
            }

            //while ((l = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(l);
            //}

            // 3. cerrar fichero

            sr.Close();

            // usando funciones con ficheros

            EscribeFichero("mifichero.txt");

        }

        static void EscribeFichero(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            sw.WriteLine("Hola Paco, como te va?");

            sw.Close();
        }
    }
}
