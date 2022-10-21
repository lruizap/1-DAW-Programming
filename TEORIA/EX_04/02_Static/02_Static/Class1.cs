using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Static
{
    class Class1
    {

        public static string compartida = ""; // variable compartida 

        public int mcd(int a, int b)
        {
            while (a != b)
            {

            }
            lock (compartida)
            {
                compartida += "a";
            }

            return a;
        }

        public static int mcd2(int a, int b)
        {
            while (a != b)
            {

            }

            return a;
        }

    }
}
