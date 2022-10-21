using System;

namespace Ej4_Lucas_Ruiz_Zapata
{
    public class Program
    {
        static void Main(string[] args)
        {
            SmartArray array = new SmartArray(5);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }

            Console.WriteLine(array.ToString());

            Console.WriteLine(array.Contains(7));
            Console.WriteLine(array.Contains(5));
            Console.WriteLine(array.IndexOf(5));


            SmartArray array2 = new SmartArray(5);
            array2[0] = 10;
            array2[1] = 8;
            array2[2] = 7;
            array2[3] = 12;
            array2[4] = 9;
            array2.Sort();
            Console.WriteLine(array2.ToString());

            array.Reverse();
            Console.WriteLine(array.ToString());

            array2.Shuffle();
            Console.WriteLine(array2.ToString());

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(array == array2);
            Console.WriteLine(array != array2);

            array.Shuffle();
            Console.WriteLine(array.ToString());

            //Console.WriteLine(array);
            //array.Shuffle();
            //Console.WriteLine(array);
            //array.Sort();
            //Console.WriteLine(array);
            //array.Reverse();
            //Console.WriteLine(array);
        }
    }
}