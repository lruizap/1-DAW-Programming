using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _09_Venta_de_Coches
{
    class AutoVenta
    {
        private static List<Coche> listaCoches = new List<Coche>();

        public AutoVenta()
        {

        }

        public static void CargaCSV(string v)
        {
            StreamReader sr = new StreamReader(v);
            string[] s;
            s = sr.ReadLine().Split(";");

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Split(";");
                string mat;
                mat = s[0];
                DateTime d = new DateTime();
                d = DateTime.Parse(s[3]);
                string marc;
                marc = s[1];
                string mod;
                mod = s[2];
                double prec;
                prec = double.Parse(s[4]);

                Coche c = new Coche(mat, d, marc, mod, prec);
                listaCoches.Add(c);
            }

            sr.Close();
        }

        public static void GuardaCSV(string v)
        {
            StreamWriter sw = new StreamWriter(v);
            for (int i = 0; i < listaCoches.Count; i++)
            {
                sw.WriteLine(listaCoches[i].Matricula + ";" + 
                             listaCoches[i].Marca + ";" + 
                             listaCoches[i].Modelo + ";" +
                             listaCoches[i].FechaMatriculacion + ";" + 
                             listaCoches[i].Precio);
            }

            sw.Close();
        }

        public static void InsertaCoche(Coche c)
        {
            listaCoches.Add(c);
        }

        public static Coche BuscaCoche(string matricula)
        {
            Coche c = null;
            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaCoches[i].Matricula == matricula)
                {
                    c = listaCoches[i];
                    i = listaCoches.Count;
                }
            }

            return c;
        }

        public static string ImprimeListado()
        {
            string s = "Matrícula".PadRight(18) + "Marca".PadRight(18) + "Modelo".PadRight(18) 
                + "Fecha Matr.".PadRight(18) + "Precio";
            string s2 = "";

            for (int i = 0; i < listaCoches.Count; i++)
            {
                s2 += listaCoches[i].Matricula.PadRight(18) + listaCoches[i].Marca.PadRight(18) + listaCoches[i].Modelo.PadRight(18) + listaCoches[i].FechaMatriculacion.ToShortDateString().ToString().PadRight(18) + listaCoches[i].Precio.ToString().PadRight(18) + "\n";
            }

            return s + "\n" + s2;
        }
    }
}
