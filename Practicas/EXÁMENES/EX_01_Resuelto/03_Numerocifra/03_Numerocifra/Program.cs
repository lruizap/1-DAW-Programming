using System;

namespace _03_Numerocifra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumeroCifra(49857));
        }

        static int NumeroCifra(int n)
        {
            int cifras = 0;

            if (n == 0)
            {
                cifras = 1;
            }
            else
            {
                while (n != 0)
                {
                    n = n / 10;
                    cifras++;
                }
            }
            

            return cifras;
        }
    }
}
