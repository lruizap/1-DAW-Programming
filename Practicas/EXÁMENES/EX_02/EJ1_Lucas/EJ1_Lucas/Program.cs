using System;

namespace EJ1_Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Oro parece, PLátano es";
            Console.WriteLine(s);
            Console.WriteLine(ConsonantesSeguidas(s));
        }

        static bool ConsonantesSeguidas(string s)
        {
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            s = s.ToLower();
            bool v = false;
            int i, j;
            for (i = 0; i < s.Length-1; i++)
            {
                if (consonantes.Contains(s[i]) && consonantes.Contains(s[i + 1]))
                {
                    v = true;
                }
            }
            return v;
        }
    }
}
