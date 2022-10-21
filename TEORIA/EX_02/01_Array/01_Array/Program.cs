using System;

namespace _01_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            int[] array; //declaramos variable

            array = new int[5]; //inicializamos el array

            int[] array2 = new int[10]; // Normalmente <-

            // de inicio, en c#, el array está lleno de 0

            Console.WriteLine(array[0]);

            //inicializar un array con datos

            int[] array3 = { 10, 20, 30, 40, 50 };

            array3[0] = 99;

            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);
            Console.WriteLine(array3[3]);
            Console.WriteLine(array3[4]);

            int i;

            for (i = 0; i < 5; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();

            int[] array4 = new int[5];
            int cont;

            cont = 4;
            for (i = 0; i < 5; i++)
            {
                Console.Write((array4[i] = cont) + " ");
                cont--;
            }

            arrayxd(array);
            modificaarray(array);

        }

        static void arrayxd(int [] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)    // adaptarse al tamaño del array 
            {
                Console.Write(a[i] + " ");
            }
        }

        static void modificaarray(int[] a)
        {
            a[0] = 99;
        }
    }
}
