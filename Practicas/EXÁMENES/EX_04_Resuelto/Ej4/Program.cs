using System;

namespace Examen3T
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

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
			

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