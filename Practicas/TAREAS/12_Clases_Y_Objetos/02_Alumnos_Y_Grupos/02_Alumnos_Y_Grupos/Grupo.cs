using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02_Alumnos_Y_Grupos
{
    class Grupo
    {
        // Atributos 

        public List<Alumno> listaAlumnos = new List<Alumno>();

        // Métodos

        /// <summary>
        /// Inserta un nuevo alumno a la lista
        /// </summary>
        /// <param name="a">Este alumno será insertado a la lista de alumnos creada (lalum)</param>
        
        public void InsertaAlumnoLista(Alumno a)
        {
            listaAlumnos.Add(a);
        }

        /// <summary>
        /// Inserta un alumno en la lista pasándole los datos por parámetro
        /// </summary>
        /// <param name="name">El nombre del alumno</param>
        /// <param name="age">La edad del alumno</param>
        /// <param name="qualification">La calificación del alumno</param>

        public void InsertaAlumnoLista2(string name, int age, double qualification)
        {
            Alumno a = new Alumno(name, age, qualification);
            listaAlumnos.Add(a);
        }

        public override string ToString()
        {
            string s1 = "\n   Nombre".PadRight(30) + "Edad".PadRight(7) + "Calificación".PadRight(15);
            string s2 = "\n ===========================".PadRight(30) + "====".PadRight(7) + "============".PadRight(15);
            string s3 = "";
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                s3 = "\n" + i + 1 + ": " + listaAlumnos[i].Nombre.PadRight(25) + listaAlumnos[i].Edad.ToString().PadLeft(4) + listaAlumnos[i].Calificacion.ToString().PadLeft(15);
            }

            return s1 + s2 + s3;
        }

        public void EscribeFicheroBinario(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(listaAlumnos.Count);
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                bw.Write(listaAlumnos[i].Nombre);
                bw.Write(listaAlumnos[i].Edad);
                bw.Write(listaAlumnos[i].Calificacion);
            }

            fs.Close();
            bw.Close();
        }

        public void LeeFicheroBinario(string fichero)
        {
            listaAlumnos.Clear();
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int n = br.ReadInt32();
            for (int i = 0; i < n; i++)
            {
                string nombre = br.ReadString();
                int ed = br.ReadInt32();
                double calif = br.ReadDouble();

                Alumno a = new Alumno(nombre, ed, calif);
                listaAlumnos.Add(a);
            }

            br.Close();
            fs.Close();
        }

        public void EscribeFicheroTexto(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            sw.WriteLine(listaAlumnos.Count);
            for (int i = 0; i < listaAlumnos.Count ; i++)
            {
                sw.WriteLine(i);
                sw.WriteLine(listaAlumnos[i].Nombre);
                sw.WriteLine(listaAlumnos[i].Edad);
                sw.WriteLine(listaAlumnos[i].Calificacion);
            }

            sw.Close();
        }

        public void LeeFicheroTexto(string fichero)
        {
            listaAlumnos.Clear();
            StreamReader sr = new StreamReader(fichero);
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)

            {
                string nombre = sr.ReadLine();
                int ed = int.Parse(sr.ReadLine());
                double calif = double.Parse(sr.ReadLine());

                Alumno a = new Alumno(nombre, ed, calif);
                listaAlumnos.Add(a);
            }
            sr.Close();
        }

        public void EscribeFicheroCSV(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].Nombre + ";" + listaAlumnos[i].Edad + ";" + listaAlumnos[i].Calificacion);
            }

            sw.Close();
        }

        public void LeeFicheroCSV(string fichero)
        {
            listaAlumnos.Clear();
            StreamReader sr = new StreamReader(fichero);
            string[] s;
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Split(";");
                string nombre = s[0];
                int ed = int.Parse(s[1]);
                double calif = double.Parse(s[2]);

                Alumno a = new Alumno(nombre, ed, calif);
                listaAlumnos.Add(a);
            }
            sr.Close();
        }
    }
}
