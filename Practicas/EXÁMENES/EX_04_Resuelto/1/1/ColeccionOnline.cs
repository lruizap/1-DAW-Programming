using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1
{
    class ColeccionOnline
    {
        private List<Videojuego> listaVideojuegos = new List<Videojuego>();

        private Videojuego LeeVideojuego(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);

            string linea1 = sr.ReadLine();

            int pos = linea1.LastIndexOf("(");
            string nombre = linea1.Substring(0, pos-1);
            string anno = linea1.Substring(pos + 1, 4);
            int annoInt = int.Parse(anno);

            List<TipoPlataforma> listaPlataformas = new List<TipoPlataforma>();

            for (int i = 0; i < 5; i++)
            {
                string linea = sr.ReadLine();
                if (linea.EndsWith("Yes"))
                {
                    //listaPlataformas.Add());
                }
            }

            Videojuego v = new Videojuego(nombre, listaPlataformas, annoInt);
            sr.Close();
            return v;
        }

        public ColeccionOnline()
        {
            string[] ficheros = Directory.GetFiles(".", "*.txt");

            for (int i = 0; i < ficheros.Length; i++)
            {
                listaVideojuegos.Add(LeeVideojuego(ficheros[i]));
            }
        }


        public void ImprimeLista(TipoPlataforma tp)
        {
            for (int i = 0; i < listaVideojuegos.Count; i++)
            {
                if (listaVideojuegos[i].Plataformas.Contains(tp))
                {
                    Console.WriteLine(listaVideojuegos[i]);
                }
            }
        }
    }
}
