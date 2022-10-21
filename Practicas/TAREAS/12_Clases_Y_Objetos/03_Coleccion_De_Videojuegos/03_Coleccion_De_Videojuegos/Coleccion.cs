using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _03_Coleccion_De_Videojuegos
{
    class Coleccion
    {
        // Atributo

        List<Videojuego> lista = new List<Videojuego>();

        // Constructor

        public Coleccion()
        {

        }

        public void InsertaVideojuego(Videojuego v)
        {
            lista.Add(v);
        }

        public void EliminaVideojuego(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        public Videojuego LeeVideojuego(int posicion)
        {
            return lista[posicion];   
        }

        public void GuardaColeccionFichero(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            int platInt;
            int tipoInt;

            for (int i = 0; i < lista.Count; i++)
            {
                sw.WriteLine(lista[i].Nombre);
                sw.WriteLine(lista[i].Anno);
                platInt = (int)lista[i].Plataforma;
                sw.WriteLine(platInt);
                tipoInt = (int)lista[i].TipoJuego;
                sw.WriteLine(tipoInt);
                sw.WriteLine(lista[i].Valoracion);
            }

            sw.Close();
        }

        public void LeeColeccionFichero(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            lista.Clear();

            string nombre;
            int anno;
            int platInt;
            Plataforma plataforma;
            int tipoInt;
            TipoJuego tipoJuego;
            int valoracion;

            while (!sr.EndOfStream)
            {
                nombre = sr.ReadLine();
                anno = int.Parse(sr.ReadLine());
                platInt = int.Parse(sr.ReadLine());
                plataforma = (Plataforma)platInt;
                tipoInt = int.Parse(sr.ReadLine());
                tipoJuego = (TipoJuego)tipoInt;
                valoracion = int.Parse(sr.ReadLine());

                Videojuego v = new Videojuego(nombre, anno, plataforma, tipoJuego, valoracion);
                lista.Add(v);
            }

            sr.Close();
        }

        public override string ToString()
        {
            string s1 = "\nNombre".PadRight(15) + "Año".PadRight(15) + "Plataforma".PadRight(17) + "Tipo de Juego".PadRight(20) + "Val.".PadRight(12);
            string s2 = "\n======================================================================================================================";
            string s3 = "";
            for (int i = 0; i < lista.Count; i++)
            {
                s3 = "\n" + lista[i].Nombre.PadRight(14) + lista[i].Anno.ToString().PadRight(15) + lista[i].Plataforma.ToString().PadRight(17) + lista[i].TipoJuego.ToString().PadRight(20) + lista[i].Valoracion.ToString().PadRight(12);
            }

            return s1 + s2 + s3;
        }

        public string ToStringNum()
        {
            string s = "";
            for (int i = 0; i < lista.Count; i++)
            {
                s = s + i + 1 + "- " + lista[i].Nombre;
            }

            return s;
        }
    }
}
