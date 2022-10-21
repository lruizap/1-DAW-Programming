using System;

namespace _02_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funciones integradas de cadenas 
            // s.contains
            // s.edswith
            // s.startswith

            string s = "patata";

            Console.WriteLine(s.Contains('p'));

            string s3 = "Equisde.Puto";
            if (s3.StartsWith("E"))
            {
                Console.WriteLine("Comeme los cojones");
            }

            string s2 = "Patata.com";
            if (s2.EndsWith(".com"))
            {
                Console.WriteLine("Es una página web");
            }

            // s.Indexof -> devuelve la posición de lo que le dices (comienza en 0) y si no está, devuelve -1
            // s.lastinfexof -> devuelve la posición de lo que le dices (comienza en final) y si no está, devuelve -1

            string s4 = "mi Pepino es divino";
            Console.WriteLine(s4.IndexOf('i'));
            Console.WriteLine(s4.LastIndexOf('o'));
            Console.WriteLine(s4.IndexOf('a'));

            int pos = s4.IndexOf("es");
            int pos2 = s4.IndexOf('i', pos);

            Console.WriteLine(pos2);

            //if (s4.Contains("s"));
            //if (s4.IndexOf("s") != -1);

            // s.insert
            // s.remove

            string s5 = "patata";
            s5 = s5.Remove(1, 2); // 2 elementos a partir de la posición 1;
            s5 = s5.Insert(2, "T"); // a partir de la posicion 2 insertar lo que tu le mandes; 
            Console.WriteLine(s5);

            s3 = s3.Remove(4, 1).Insert(4, "X");
            Console.WriteLine(s5);

            // s.substring

            string s6 = "camaleón";
            Console.WriteLine(s6.Substring(0,4)); // a partir del 0, 4
            Console.WriteLine(s6.Substring(4,4)); // a partir del 4, 4
            Console.WriteLine(s6.Substring(4)); // a partir del 4

            string s7 = s6.Substring(0, 4) + "X" + s6.Substring(4);
            Console.WriteLine(s7);

            string s8 = s7.Substring(0, 4) + s7.Substring(5);
            Console.WriteLine(s8);

            string s9 = "C" + s8.Substring(1);
            Console.WriteLine(s9);

            string s10 = s9.Substring(0,4) + "L" + s9.Substring(5);
            Console.WriteLine(s10);

            // s.replace

            string s11 = "patata     tomate     pimiento";
            s11 = s11.Replace("     "," ");
            Console.WriteLine(s11); // remplaza todo pero solo 1 pasada 

            // s.Trim
            // s.TrimStart
            // s.TrimEnd

            string s12 = "    patata    ";
            Console.WriteLine(">" + s12 + "<");
            Console.WriteLine(">" + s12.TrimStart() + "<");
            Console.WriteLine(">" + s12.TrimEnd() + "<");
            Console.WriteLine(">" + s12.Trim() + "<");

            // s.tolower
            // s.toupper

            string s13 = "patata TOMATE";
            Console.WriteLine(s13);
            Console.WriteLine(s13.ToUpper());
            Console.WriteLine(s13.ToLower());

            string s14 = char.ToUpper(s11[0]) + s13.Substring(1);
            // s14 = s13.Substring(0, 1).ToUpper() + s13.Substring(1);
            Console.WriteLine(s14);

            // s.padleft
            // s.PadRight

            Console.WriteLine("232,57 $".PadLeft(11));
            Console.WriteLine("1,35 $".PadLeft(11));
            Console.WriteLine("94.584,48 $".PadLeft(11));
            Console.WriteLine("45,00 $".PadLeft(11));

            // Maniobras con los for

            int i, cont;
            cont = 1;
            string s15 = "patata";
            string s16 = "";

            for (i = 0; i < s15.Length; i++)
            {
                if (s15[i] != 'a')      
                {
                    s16 = s16 + s13[i];
                }
                else
                {
                    s16 = s16 + cont;
                    cont++;
                }
            }
            Console.WriteLine(s16);

            // Funciones con cadenas

            s16 = s16 + QuitaLetra(s16);

            // s.Split
            // string.Join

            string s20 = "Hola don pepito hola don jose";
            string[] palabras = s20.Split(" ");

            for (i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }

            Console.WriteLine(palabras[2][0]); // de la palabra 2, la letra 0;

            palabras[2] = "Juanito";
            string s21 = string.Join(' ', palabras);
            Console.WriteLine(s21);

            // isdigit isletter

            //if (char.IsLetter('A')) ;
            //if (char.IsDigit('1')) ;
            //...
            //char.Is...;


            string st = "tontito";
            st = st.Remove(1, 2);
            Console.WriteLine(st);

        }

        static string QuitaLetra(string s)
        {
            int i;
            string s2 = "";
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a')
                {
                    s2 = s2 + s[i];
                }
            }
            return s2;
        }
    }
}
