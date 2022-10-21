using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _07_Profesor_Y_Tribunal
{
    class Tribunal
    {
        private static List<Profesor> l = new List<Profesor>();

        public Tribunal(string nombreFichero)
        {
            nombreFichero = "profesores1csharp.bin";
            LeeFichero(nombreFichero);
        }

        public static void LeeFichero(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            l.Clear();

            string nombre;
            string dni;
            TipoGenero t;

            while (fs.Position < fs.Length)
            {
                nombre = br.ReadString();
                dni = br.ReadString();
                t = (TipoGenero)br.ReadInt32();
                Profesor p = new Profesor(nombre, dni, t);
                l.Add(p);
            }

            fs.Close();
            br.Close();
        }

        public void EligeTribunal()
        {
            int i;
            int h = 0, m = 0, p;
            List<Profesor> tribunal = new List<Profesor>();
            Random r = new Random();
            p = r.Next(l.Count);

            for (i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }

            i = p;
            while (h != 2 || m != 2)
            {
                if (l[i].Genero == TipoGenero.Hombre && h < 2)
                {
                    Console.WriteLine(l[i]);
                    h++;
                    tribunal.Add(l[i]);
                }

                if (l[i].Genero == TipoGenero.Mujer && m < 2)
                {
                    Console.WriteLine(l[i]);
                    m++;
                    tribunal.Add(l[i]);
                }

                i++;

                if (i == l.Count)
                {
                    i = 0;
                }
            }

            EscribeLista(tribunal);
        }

        static void EscribeLista(List<Profesor> l)
        {
            int i;
            if (l.Count > 0)
            {
                Console.Write("< ");
                for (i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + "\n. ");
                }
                Console.WriteLine(l[l.Count - 1] + " >");
            }
            else
            {
                Console.WriteLine("<>");
            }
        }
    }
}
