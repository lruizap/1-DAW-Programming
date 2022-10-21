using System;
using System.Collections.Generic;

namespace _04_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ejemplo> l = new List<ejemplo>();
            l.Add(new ejemplo(1, 1));
            l.Add(new ejemplo(7, 4));
            l.Add(new ejemplo(8, 1));

            l.Sort();

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
        }
    }
}
