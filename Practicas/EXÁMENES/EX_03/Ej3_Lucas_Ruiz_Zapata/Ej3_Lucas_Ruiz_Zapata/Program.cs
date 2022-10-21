using System;
using System.Collections.Generic;
using System.IO;

namespace Ej3_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            string origen = "laregenta.txt", destino = "laregentaInv.txt";
            InvierteMayusculas(origen, destino);
        }

        static void InvierteMayusculas(string origen, string destino)
        {
            StreamReader sr = new StreamReader(origen);
            StreamWriter sw = new StreamWriter(destino);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsWhiteSpace(line[i]))
                    {
                        sw.Write(line[i]);
                    }
                    else
                    {
                        if (char.IsUpper(line[i]))
                        {
                            sw.Write(char.ToLower(line[i]));
                        }
                        else
                        {
                            sw.Write(char.ToUpper(line[i]));
                        }
                    }
                }
            }
            sw.Close();
            sr.Close();
        }
    }
}
