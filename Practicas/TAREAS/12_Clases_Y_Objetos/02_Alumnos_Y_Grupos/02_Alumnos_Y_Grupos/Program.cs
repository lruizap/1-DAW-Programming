using System;
using System.Collections.Generic;

namespace _02_Alumnos_Y_Grupos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno a = new Alumno("Paco", 20, 5.4);
            //Console.WriteLine(a.ToString());

            Grupo g = new Grupo();

            //Console.WriteLine("Introduce el nombre del alumno");
            //string name = Console.ReadLine();
            //Console.WriteLine("Introduce la edad del alumno");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce la calificación del alumno");
            //double qualification = double.Parse(Console.ReadLine());

            //g.InsertaAlumnoLista2(name, age, qualification);

            //g.EscribeFicheroBinario("Grupos_Binario.bin");

            g.LeeFicheroBinario("Grupos_Binario.bin");

            //g.EscribeFicheroTexto("Grupos_TXT.txt");

            //g.LeeFicheroTexto("Grupos_TXT.txt");

            //g.EscribeFicheroCSV("Grupos_CSV.csv");

            //g.LeeFicheroCSV("Grupos_CSV.csv");

            Console.WriteLine(g.ToString());
        }
    }
}
