using System;
using System.Collections.Generic;
using System.Linq;

namespace Estudiar_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l6 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            l6.RemoveRange(0, 4); // te borra los 4 elementos a partir del 0
            EscribeLista(l6);

            List<int> l7 = new List<int>() { 10, 2, 10, 4, 5, 10, 7, 8, 9, 10 };
            l7.RemoveAll(p => p == 10); //borra de la lista, cualquier elemento (p) que sea igual a 10
            EscribeLista(l7);

            List<int> l = new List<int>();
            MeteLista110(l);
            EscribeLista(l);

            Console.WriteLine(l.IndexOf(10)); // devuelve el PRIMER número(9) del elemento que cumpla lo que dice(10)

            List<int> l2 = new List<int>() { 1, 2, 10, 3, 4, 5, 6, 10, 7, 8, 9, 10, 11, 10, 12, 10, 13, 10, 14, 10, 15 };
            l2.Remove(10); // Borra SOLO 1 elemento que se le indica de la lista. Es un valor, no una posición.
            EscribeLista(l2);
            Console.WriteLine(l2.IndexOf(10));
            Console.WriteLine(l2.FindIndex(p => p % 2 == 0)); // devuelve la posición del primer elemento que cumple la función
            EscribeLista(l2.FindAll(p => p < 5)); // devuelve una lista de elementos que cumplen la función
            // Ej.: contar los elementos impares
            Console.WriteLine("Números impares = " + l2.FindAll(p => p % 2 != 0).Count);

            int[] d = new int[10];
            l2.CopyTo(5, d, 0, 10); // desde donde, array al que copiar, desde donde de lista, número elementos que concuerde con el tamaño del array;
            EscribeArray(d);

            Console.WriteLine(l2.Min());
            Console.WriteLine(l2.Max());
            Console.WriteLine(l2.Sum());
            Console.WriteLine(l2.Average()); //media
        }

        static void MeteLista110(List<int> l) // introduce en la lista los números del 1 al 10
        {
            int i;

            for (i = 1; i <= 10; i++)
            {
                l.Add(i);
            }
        }

        static void EscribeLista(List<int> l)
        {
            int i;
            if (l.Count > 0)
            {
                Console.Write("< ");
                for (i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }
                Console.WriteLine(l[l.Count - 1] + " >");
            }
            else
            {
                Console.WriteLine("<>");
            }

            //Console.Write("< ");
            //for (int i = 0; i < l.Count; i++)
            //{
            //    Console.Write(l[i] + " ");
            //}
            //Console.WriteLine(">");

        }

        static void EscribeArray(int[] l)
        {
            int i;
            if (l.Length > 0)
            {
                Console.Write("< ");
                for (i = 0; i < l.Length - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }
                Console.WriteLine(l[l.Length - 1] + " >");
            }
            else
            {
                Console.WriteLine("<>");
            }

            //Console.Write("< ");
            //for (int i = 0; i < l.Count; i++)
            //{
            //    Console.Write(l[i] + " ");
            //}
            //Console.WriteLine(">");

        }

    }
}
