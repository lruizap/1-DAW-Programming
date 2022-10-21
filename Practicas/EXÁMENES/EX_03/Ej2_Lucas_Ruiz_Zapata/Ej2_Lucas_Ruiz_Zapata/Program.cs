using System;
using System.IO;

namespace Ej2_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Console.WriteLine("Dime que hay en esa posición");
            string dato = Console.ReadLine();
            Console.WriteLine(CompruebaCoordenadas(a, dato));
        }

        static bool CompruebaCoordenadas(int[,] a, string dato)
        {
            FileStream fs = new FileStream("tarjeta5x5.cdn", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Random r = new Random();
                r.Next(1, 5 + 1);
                Random r2 = new Random();
                r2.Next(1, 5 + 1);
                string datoComprobar;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        
                    }
                }

                if (dato == br.BaseStream(a[r, r2]))
                {

                }
            }

            fs.Close();
            br.Close();
        }
    }
}
