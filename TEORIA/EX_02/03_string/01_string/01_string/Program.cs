using System;
using System.Text;

namespace _01_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "patata";

            int i;
            for (i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            string s2 = s; // copiar la string. no es como los array;

            s = s + "!";
            s = s + 6456; // transforma lo que no es una cadena en cadena; pura comodidad;

            string s3 = "P";

            for (i = 1; i < s2.Length; i++)
            {
                s3 = s3 + s2[i]; // esto lo que hace es crear otra string y sustituirla por la anterior pero la 
                                 // anterior sigue existiendo;
            }

            Console.WriteLine(s3);

            string s4 = "P" + s2.Substring(1);
            Console.WriteLine(s4);

            #region StringBuilder

            //---------------------------------------------------------------------

            // String builder;

            StringBuilder sb = new StringBuilder();
            sb.Append("yohohoho");
            for (i = 0; i < s2.Length; i++)
            {
                sb.Append(s2[i]);
            }
            string s5 = sb.ToString();
            Console.WriteLine(s5);

            #endregion


        }
    }
}
