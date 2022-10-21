using System;

namespace EJ2_Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el tamaño del array");
            int n = int.Parse(Console.ReadLine());
            Console.Write(Escribearray(ArrayCuadrados(n)));
        }

        static int[] ArrayCuadrados(int n)
        {
            {
                int[] a = new int[n];
                
                if (n < 1)
                {
                    string s = "ERROR";
                    Console.Write(s);
                }
                else
                {
                    int i;
                    for (i = 1; i < a.Length - 1; i++)
                    {
                        a[i + 1] = a[i] + 1;
                        a[i] = a[i] * a[i];
                    }
                    a[a.Length - 1] = a[i] * a[i];
                    
                }

                return a;
            }
        }

        static string Escribearray(int[] a)
        {
            int i;
            string s = "";
            if (a.Length > 0)
            {
                s = "[";
                for (i = 0; i < a.Length - 1; i++)
                {
                    s = s + a[i] + ";";
                }
                s = s + a[a.Length - 1] + "]";
            }
            else
            {
                s = "[]";
            }
            return s;
        }
    }
}
