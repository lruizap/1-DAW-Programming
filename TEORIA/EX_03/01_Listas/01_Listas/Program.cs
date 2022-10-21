using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista == array pero sin tamaño fijo 

            List<int> l = new List<int>();

            List<int> l2 = new List<int>();

            List<bool> v = new List<bool>();

            List<double> d = new List<double>();

            List<string> s = new List<string>();

            //...

            EscribeLista(l);
            l.Add(5);
            EscribeLista(l);
            l[0] = 10;
            EscribeLista(l);

            l[0] = 0;
            MeteLista110(l);
            EscribeLista(l);

            #region insertar

            // Insertar cosas en una lista

            // add = añade elemento al final de la list
            l2.Add(99);
            // Insert = añade elemento en la posicion que le digas
            l2.Insert(0, -99); // inserta el 99 en la posición 0 (al principio)
            EscribeLista(l2);

            // addRenge y insertrange
            List<int> l3 = new List<int>();
            int[] a = { 11, 12, 13 };
            int[] a2 = { 1, 2, 3 };
            l3.AddRange(a);
            EscribeLista(l3);
            l3.InsertRange(2, a2);
            EscribeLista(l3);

            List<char> lc = new List<char>();
            lc.AddRange("patata");

            // al crear la lista tambien se pueden insertar cosas directamente
            List<int> l4 = new List<int>() {-4,-3,-2,-1,0 };
            EscribeLista(l4);

            // o se puede crear una lista como copia de otra cosa 
            List<int> l5 = new List<int>(a);
            EscribeLista(l5);

            #endregion

            #region borrar cosas lista

            // borrar cosas de una lista
            // Borra el elemento que esté en la posición que se indica
            List<int> l6 = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            l6.RemoveAt(0);
            EscribeLista(l6);
            // remove borra el elemento que le pasas (pero solamente 1)
            l6.Remove(10);
            EscribeLista(l6);
            // removeRage te borra un rango (posición inicial y número de elementos)
            l6.RemoveRange(0, 4); // te borra los cuatro elementos a partir del 
            EscribeLista(l6);
            // RemoveAll
            List<int> l7 = new List<int>() { 10, 2, 10, 4, 5, 10, 7, 8, 9, 10 };
            l7.RemoveAll(p => p == 10); //borra de la lista, cualquier elemento (p) que sea igual a 10
            EscribeLista(l7);
            // clear -> lo borra TODO
            l.Clear();
            EscribeLista(l);

            #endregion

            #region buscar cosas

            MeteLista110(l);
            EscribeLista(l);

            // contains

            if (l.Contains(10))
            {
                Console.WriteLine("Está");
            }

            // indexof

            Console.WriteLine(l.IndexOf(10));

            // find devuelve primer elemento que cumpla funcion

            Console.WriteLine(l.Find(p => p % 2 == 0));

            // findIndex devuelve posicion primer elemento que cumpla funcion

            Console.WriteLine(l.FindIndex(p => p % 2 == 0));

            // FindAll devuelve lista elementos que cumple la funcion

            EscribeLista(l.FindAll(p => p < 5));

            // Ej.: contar los elementos impares
            Console.WriteLine("Números impares = " + l.FindAll(p => p % 2 != 0).Count);

            #endregion

            #region otras funciones

            //reverse le da la vuelta a la lista

            l.Reverse();
            EscribeLista(l);

            // sort te la ordena en orden ascendnte

            l.Sort();
            EscribeLista(l);

            // toarray nos convierte la lista en un array
            //int[] c = l.ToArray();

            //int[] d = new int[5];
            //l.CopyTo(0, d, 0, 5);
            //EscribeArray(d);

            // funciones extra
            // poner "using System.Linq;"

            l.Min();
            l.Max();
            l.Sum();     //suma
            l.Average(); //media

            #endregion
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

        static void MeteLista110(List<int> l)
        {
            int i;

            for (i = 1; i <= 10; i++)
            {
                l.Add(i);
            }
        }
    }
}
