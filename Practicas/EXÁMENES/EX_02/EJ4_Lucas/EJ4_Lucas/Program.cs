using System;

namespace EJ4_Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el tamaño de los arrays");
            int n = int.Parse(Console.ReadLine());
            int[] E1 = new int[n];
            int[] E2 = new int[n];
            Console.WriteLine("Dime el primer equipo");
            LeeArray(E1);
            Console.WriteLine("Dime el segundo equipo");
            LeeArray(E2);
            //int[] E1 = new int[11] { 93, 87, 89, 82, 80, 88, 76, 80, 92, 91, 78 };
            //int[] E2 = new int[11] { 87, 87, 85, 83, 87, 85, 82, 86, 92, 95, 83 };
            Console.WriteLine(EscribeArray(E1));
            Console.WriteLine(EscribeArray(E2));
            if (ErrorDatos(E1,E2) == false && ErrorDatos2(E1,E2) == false)
            {
                Console.WriteLine(FootBallCards(E1, E2));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static bool ErrorDatos2(int[] e1, int[] e2)
        {
            bool v = false;
            for (int i = 0; i < e1.Length; i++)
            {
                for (int j = 0; j < e2.Length; j++)
                {
                    if (e1[i] > 100 || e1[i] < 0 || e2[j] > 100 || e2[j] < 0)
                    {
                        v = true;
                    }
                }
            }
            return v;
        }

        static int FootBallCards(int[] e1, int[] e2)
        {
            int res = 0, i, j, punt1 = 0, punt2 = 0;

            for (i = 0; i < e1.Length; i++)
            {
                for (j = 0; j < e2.Length; j++)
                {
                        if (e1[i] > e2[j])
                        {
                            punt1++;
                        }
                        else
                        {
                            if (e1[i] < e2[j])
                            {
                                punt2++;
                            }
                        }
                }
            }

            if (MaxArray(e1) > MaxArray(e2))
            {
                punt1 = punt1 + 2;
            }
            else
            {
                if (MaxArray(e1) == MaxArray(e2))
                {
                    
                }
                else
                {
                    punt2 = punt2 + 2;
                }
            }

            if (punt1 > punt2)
            {
                res = 1;
            }
            else
            {
                if (punt2 > punt1)
                {
                    res = 2;
                }
            }

            return res;
        }

        static bool ErrorDatos(int[] e1, int[] e2)
        {
            bool v = false;
            if (e1.Length != 11 || e2.Length != 11)
            {
                v = true; 
            }
            return v;
        }

        static int MaxArray(int[] equipo1)
        {
            int max1;
            max1 = equipo1[1];
            for (int i = 0; i < equipo1.Length; i++)
            {
                if (equipo1[i] > max1)
                {
                    max1 = equipo1[i];
                }
            }
            return max1;
        }

        static string EscribeArray(int[] a)
        {
            int i;
            string s = "";
            if (a.Length > 0)
            {
                s = "[";
                for (i = 0; i < a.Length - 1; i++)
                {
                    s = s + a[i] + ", ";
                }
                s = s + a[a.Length - 1] + "]";
            }
            else
            {
                s = "[]";
            }
            return s;
        }

        static string LeeArray(int[] a)
        {
            int i, n;
            string s = "";

            s = "Dame los elementos del array";
            for (i = 0; i < a.Length; i++)
            {
                s = "Dime el elemento " + i + " : ";
                n = int.Parse(Console.ReadLine());
                a[i] = n;
            }
            return s;
        }
    }
}
