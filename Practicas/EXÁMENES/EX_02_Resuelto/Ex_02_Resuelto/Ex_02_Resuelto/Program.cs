using System;

namespace Ex_02_Resuelto
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static bool ConsonantesSeguidas(string s)
        {
            int i;
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            s = s.ToLower();

            for (i = 0; i < s.Length - 1; i++)
            {
                if (consonantes.Contains(s[i]) && consonantes.Contains(s[i + 1]))
                {
                    return true;
                }
            }

            return false;
        }

        //static bool EsConsonante(char c)
        //{
        //    string consonantes = "bcdfghjklmnñpqrstvwxyz"; consonantes.ToLower();
        //    return consonantes.Contains(c);
        //}

        static int[] ArrayCuadrados(int n)
        {
            if (n > 0)
            {
                int i;
                int[] a = new int[n];

                for (i = 0; i < a.Length; i++)
                {
                    a[i] = (i + 1) * (i + 1);
                }

                return a;
            }
            else
            {
                Console.WriteLine("ERROR");
                return new int[0];
            }

        }

        static string MayusculasAlternas(string s)
        {
            int i, j;
            string p, p2;
            string[] palabras = s.Split(" ");

            for (i = 0; i < palabras.Length; i++)
            {
                p = palabras[i];
                p2 = "";

                for (j = 0; j < p.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        p2 = p2 + char.ToUpper(p[j]);
                    }
                    else
                    {
                        p2 = p2 + char.ToLower(p[j]);
                    }
                }

                palabras[i] = p2;
            }

            string resultado = string.Join(' ', palabras);
            return resultado;
        }


        static int FootballCards(int[] equipo1, int[] equipo2)
        {
            if (equipo1.Length == 11 && equipo2.Length == 11)
            {

                int i;
                bool bien = true;

                for (i = 0; i < 11; i++)
                {
                    if (equipo1[i] < 0 || equipo2[i] < 0 || equipo1[i] > 100 || equipo2[i] > 100)
                    {
                        bien = false;
                        break;
                    }
                }

                int puntos1 = 0, puntos2 = 0;

                for (i = 0; i < 11; i++)
                {
                    if (equipo1[i] > equipo2[i])
                    {
                        puntos1++;
                    }
                    else
                    {
                        if (equipo1[i] < equipo2[i])
                        {
                            puntos2++;
                        }
                    }
                }

                if (MaxArray(equipo1) > MaxArray(equipo2))
                {
                    puntos1 = puntos1 + 2;
                }
                else
                {
                    if (MaxArray(equipo1) < MaxArray(equipo2))
                    {
                        puntos2 = puntos2 + 2;
                    }
                }

                Console.WriteLine(puntos1);
                Console.WriteLine(puntos2);

                if (puntos1 > puntos2)
                {
                    return 1;
                }
                else
                {
                    if (puntos1 == puntos2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }

            }

            static int MaxArray(int[] a)
            {
                int i;
                int max = a[0];

                for (i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                return max;
            }
        }
    }
}
