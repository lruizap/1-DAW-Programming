using System;
using System.Collections.Generic;
using System.IO;

namespace Ej1_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneraServidorDHCP();
        }

        static void GeneraServidorDHCP()
        {
            StreamWriter sw = new StreamWriter("GeneraServidorDHCP.txt");
            string primeraFila = "subnet 10.0.0.0 netmask 255.0.0.0 {", ultima = "}", line;
            int[] ip = { 0, 0, 0, 0 };
            sw.WriteLine(primeraFila);
            for (int i = 0; i <= 200; i++)
            {
                Random r2 = new Random();
                Random r3 = new Random();
                Random r4 = new Random();
                line = "\t range 10." + r2.Next(1, 255 + 1).ToString() + "." + r3.Next(1, 255 + 1).ToString() + "." + r4.Next(1, 255 + 1).ToString() + ";";
                EliminaRepetidos(line);
            }
            sw.WriteLine(ultima);
            sw.Close();
        }

        static void EliminaRepetidos(string l)
        {
            int i;
            string l2 = "";

            for (i = 0; i < l.Length; i++)
            {
                if (!l2.Contains(l[i]))
                {
                    l2 = l2 + l[i];
                }
            }
            l = "";
            for (i = 0; i < l2.Length; i++)
            {
                l = l + l2[i];
            }
        }

    }
}
