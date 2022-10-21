using System;
using System.Collections.Generic;

namespace _06_FicherosRegistros
{
    class Program
    {

        public class coche
        {
            public string Matricula, Marca, Modelo;
            public bool EsElectrico;
            public int NumeroKilometros;
        }

        public class Posicion
        {
            public int fila, columna;

        }

        static void Main(string[] args)
        {
            // Registro --> tipo de datos compuesto
            // tienen unos pocos datos pero no tienen pq ser del mismo tipo

            coche c = new coche();

            c.Matricula = "8745BCD";
            c.Marca = "Fiat";
            c.Modelo = "500";
            c.EsElectrico = false;
            c.NumeroKilometros = 200000;

            coche c2 = new coche();

            c2.Matricula = "9879PPK";
            c2.Marca = "Rover";
            c2.Modelo = "400";
            c2.EsElectrico = false;
            c2.NumeroKilometros = 256787;

            List<coche> l = new List<coche>();

            l.Add(c);
            l.Add(c2);

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i].Marca + " " + l[i].Modelo);
            }
        }

    }
}
