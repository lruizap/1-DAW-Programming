using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ej1_Lucas_Ruiz_Zapata
{
    class ColeccionOnline
    {
        // Atributo

        /// <summary>
        /// Una lista que contiene los videojuegos de la colección
        /// </summary>
        
        List<Videojuego> listaVideojuegos = new List<Videojuego>();

        // Método privado

        /// <summary>
        /// Lee el fichero que le pasamos y añade un videojuego a la lista
        /// </summary>
        /// <param name="fichero">el nombre del fichero que contiene los datos del videojuego</param>

        private Videojuego LeeVideojuego(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            List<TipoPlataforma> listaPlataformas = new List<TipoPlataforma>();

            string nombre = "",l ,s2, s3, comp;
            int anno;
            string[] trozo;

            l = sr.ReadLine();

            //if (l.Contains("("))
            //{
            //    l.Substring();
            //}

            s2 = l.Replace('(', ',');

            s3 = s2.Replace(')', ' ');

            trozo = s3.Split(",", StringSplitOptions.RemoveEmptyEntries);

            nombre = trozo[0];

            anno = int.Parse(trozo[1]);


            while (!sr.EndOfStream)
            {
                comp = sr.ReadLine();

                if (comp == "Steam: Yes")
                {
                    listaPlataformas.Add(TipoPlataforma.Steam);
                }

                if (comp == "Epic: Yes")
                {
                    listaPlataformas.Add(TipoPlataforma.Epic);
                }

                if (comp == "GOG: Yes")
                {
                    listaPlataformas.Add(TipoPlataforma.GOG);
                }

                if (comp == "Humble: Yes")
                {
                    listaPlataformas.Add(TipoPlataforma.Humble);
                }

                if (comp == "Amazon: Yes")
                {
                    listaPlataformas.Add(TipoPlataforma.Amazon);
                }
            }

            Videojuego v = new Videojuego(nombre, listaPlataformas, anno);

            sr.Close();
            return v;
        }

        // constructor

        public ColeccionOnline()
        {
            string carp = Directory.GetCurrentDirectory();
            string[] fichero = Directory.GetFiles(carp);

            for (int i = 0; i < fichero.Length; i++)
            {
                FileInfo f = new FileInfo(fichero[i]);
                if (f.Extension == ".txt")
                {
                    listaVideojuegos.Add(LeeVideojuego(fichero[i]));
                }
            }
        }

        // Método Imprime Lista

        public void ImprimeLista(TipoPlataforma tp)
        {
            string s = "";
            for (int i = 0; i < listaVideojuegos.Count; i++)
            {
                if (listaVideojuegos[i].Plataformas.Contains(tp))
                {
                    s += "Nombre: " + listaVideojuegos[i].Nombre.ToString().PadRight(40) + "Año: " + listaVideojuegos[i].Anno.ToString()+ "\n";
                }
            }

            string s2 = "Plataforma : " + tp + "\n" + s;
            Console.WriteLine(s2);
        }
    }
}
