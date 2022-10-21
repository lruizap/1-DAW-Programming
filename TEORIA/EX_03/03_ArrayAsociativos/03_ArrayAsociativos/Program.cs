using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ArrayAsociativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();

            dict1["patata"] = 5;
            dict1["tomate"] = 10;
            dict1["pimiento"] = 15;

            Console.WriteLine(dict1["tomate"]);

            Dictionary<string, string> capitales = new Dictionary<string, string>();

            capitales["España"] = "Madrid";
            capitales["Malasia"] = "Kuala Lumpur";
            capitales["Filipinas"] = "Manila";

            Console.WriteLine(capitales["Filipinas"]);

            Dictionary<int, string> cadenas = new Dictionary<int, string>();

            cadenas[0] = "patata";
            cadenas[100] = "pimiento";
            cadenas[1000] = "tomate";

            Console.WriteLine(cadenas[1000]);

            //int i;
            //for (i = 0; i < 100; i++)
            //{
            //    if (cadenas.ContainsKey(i))
            //    {
            //        Console.WriteLine(cadenas[i]);
            //    }
            //}

            foreach (KeyValuePair<int, string> pareja in cadenas)
            {
                // var es el tipo de dato --> calquier cosa --> no usar :D

                Console.WriteLine(pareja.Key + " --> " + pareja.Value);
            }

            Dictionary<string, double> locTemp = new Dictionary<string, double>()
            {
                { "Jerez" , 18.9},
                { "Tarifa" , 14.1},
                { "Barbate" , 18.6}
            };

            HaceCalor(locTemp);

            foreach (KeyValuePair<string, double> pareja in locTemp)
            {
                Console.WriteLine(pareja.Key + " --> " + pareja.Value);
            }

            Dictionary<int, string> diasemana = new Dictionary<int, string>();
            diasemana[1] = "Lunes";

            string[] diasemana1 = { "", "Lunes", "Martes", "Miércoles" };


        }

        static int ModaLista(List<int> l)
        {
            Dictionary<int, int> valorRep = new Dictionary<int, int>();
            int valor;

            for (int i = 0; i < l.Count; i++)
            {
                valor = l[i];

                //if (valorRep.ContainsKey(l[i]))
                //{
                //    valorRep[valor]++;
                //}
                //else
                //{
                //    valorRep[valor] = 1;
                //}

                if (valorRep.TryAdd(valor, 1))
                {
                    valorRep[valor]++;
                }
            }

            int maxRep = valorRep.Values.Max();

            foreach (KeyValuePair<int, int> p in valorRep)
            {
                if (p.Value == maxRep)
                {
                    return p.Key;
                }
            }

            valorRep.FirstOrDefault(p => p.Value == maxRep);

            return -1;
        }

        static string SustituyeHTML(string html)
        {
            int i;

            Dictionary<char, string> sustituciones = new Dictionary<char, string>();

            sustituciones['á'] = "&aacute;";
            sustituciones['é'] = "&eacute;";
            sustituciones['í'] = "&iacute;";
            sustituciones['ó'] = "&oacute;";
            sustituciones['ú'] = "&uacute;";

            string cadena = "";

            for (i = 0; i < html.Length; i++)
            {
                if (sustituciones.ContainsKey(html[i]))
                {
                    cadena = cadena + sustituciones[html[i]];
                }
                else
                {
                    cadena = cadena + html[i];
                }
            }
            return cadena;
        }

        static void HaceCalor(Dictionary<string, double> locTemp)
        {
            double media = locTemp.Values.Average();

            foreach (KeyValuePair<string,double> p in locTemp)
            {
                if (p.Value < media)
                {
                    locTemp.Remove(p.Key);
                }
            }
        }
    }
}