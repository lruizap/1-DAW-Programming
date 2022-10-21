using System;

namespace EJ3_Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "La película del verano es OPERACIÓN CAMARÓN";
            Console.WriteLine(MayusculasPrimera(MayusculasAlternas(s)));
        }

        static string MayusculasAlternas(string s)
        {
            int i, j;
            string palabra, s2 = "" ;
            string[] array = s.Split(" ");
            for (i = 0; i < array.Length; i++)
            {
                palabra = array[i];

                for (j = 0; j < palabra.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        char letra = palabra.ToUpper()[j];
                        palabra = palabra.Remove(j, 1);
                        palabra = palabra.Insert(j, letra.ToString());
                    }
                    else
                    {
                        char letra = palabra.ToLower()[j];
                        palabra = palabra.Remove(j, 1);
                        palabra = palabra.Insert(j, letra.ToString());
                    }
                }
                s2 = s2 + palabra + " ";
            }
            return s2;
        }

        //static bool Esp(string s)
        //{
        //    int i;
        //    bool v = false;
        //    string palabra = "";
        //    string[] array = s.Split(" ");
        //    for (i = 0; i < array.Length; i++)
        //    {
        //        palabra = array[i];
        //        char esp = palabra[i];

        //        if (char.IsWhiteSpace(esp))
        //        {
        //            v = true;
        //        }
        //    }
        //    return v;
        //}

        static string MayusculasPrimera(string s)
        {
            int i;
            string palabra;
            string[] array = s.Split(" ");
            string s2 = "";
            for (i = 0; i < array.Length-1; i++)
            {
                palabra = array[i];

                char letra = palabra.ToUpper()[0];
                palabra = palabra.Remove(0, 1);
                palabra = palabra.Insert(0, letra.ToString());
                s2 = s2 + palabra + " ";
            }
            return s2;
        }
    }
}
