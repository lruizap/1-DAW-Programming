using System;

namespace _01_Parámetros
{
    class Program
    {
        static void Main(string[] args)
        {
            int uno = 4;

            incrementa(ref uno);

            Console.WriteLine(uno);

            int a, b, c;
            Devuelve123(out a, out b, out c);
            Console.WriteLine(a + "," + b + "," + c);
        }

        static void incrementa(ref int n)
        {
            n = n + 1;
        }

        static int incrementano(int n)
        {
            n = n + 1;
            return n;
        }

        static void Devuelve123(out int n1, out int n2, out int n3)
        {
            n1 = 1;
            n2 = 2;
            n3 = 3;
        }

    }
}
