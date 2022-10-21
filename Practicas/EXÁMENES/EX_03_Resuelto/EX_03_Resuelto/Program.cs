using System;
using System.Collections.Generic;
using System.IO;

namespace EX_03_Resuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeneraServidorDHCP("dhcp.txt", 50);

            //if (CompruebaCoordenadas("tarjeta8x10.cdn"))
            //{
            //    Console.WriteLine("has acertado");
            //}
            //else
            //{
            //    Console.WriteLine("alert!!");
            //}

            //InvierteMayusculas("laregenta.txt", "laregentaInv.txt");

            int[,] tableroAjedrez = { { 0, 0, 0, 0, 0, 1, 0, 0 },
                          { 0, 0, 0, 1, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 1, 0 },
                          { 1, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 1 },
                          { 0, 1, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 1, 0, 0, 0 },
                          { 0, 0, 1, 0, 0, 0, 0, 0 } };

            Console.WriteLine(Comprueba1Dama(tableroAjedrez));

        }

        static bool Comprueba1Dama(int[,] tablero, int fila, int columna)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == fila || j == columna || (i-j) == (fila-columna) || (i+j) == (fila+columna))
                    {
                        if (!(i == fila || j == columna))
                        {
                            if (tablero[i, j] != 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        static bool CompruebaDamasTabero(int[,] tablero)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tablero[i,j] != 0)
                    {
                        if (Comprueba1Dama(tablero, i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        static void InvierteMayusculas(string fichero, string destino)
        {
            StreamReader sr = new StreamReader(fichero);
            StreamWriter sw = new StreamWriter(destino);

            string linea;
            string linea2;
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();

                linea2 = "";

                for (int i = 0; i < linea.Length; i++)
                {
                    if (char.IsLetter(linea[i]))
                    {
                        if (char.IsUpper(linea[i]))
                        {
                            linea2 = linea2 + char.ToLower(linea[i]);
                        }
                        else
                        {
                            linea2 = linea2 + char.ToUpper(linea[i]);
                        }
                    }
                    else
                    {
                        linea2 = linea2 + linea[i];
                    }
                }

                sw.WriteLine(linea2);
            }
        }

        static bool CompruebaCoordenadas(string v)
        {
            FileStream fs = new FileStream(v, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int filas = br.ReadInt32();
            int columnas = br.ReadInt32();

            string[,] array = new string[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    array[i, j] = br.ReadString();
                }
            }

            br.Close();
            fs.Close();

            EscribeArrayBI(array);

            Random r = new Random();
            int miFila = r.Next(filas);
            int miColumna = r.Next(columnas);

            Console.WriteLine("¿Cuál es el valor de la posición ( " + miFila+1 + "; " + miColumna+1 + " )?");
            string respuesta = Console.ReadLine();

            if (respuesta == array[miFila, miColumna])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void EscribeArrayBI(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void GeneraServidorDHCP(string fichero, int nIP)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int n2, n3, n4;
            string ip;
            Random r = new Random();
            List<string> lista = new List<string>();
            sw.WriteLine("subnet 10.0.0.0 netmask 255.0.0.0 {");

            while (lista.Count < nIP)
            {
                n2 = r.Next(256);
                n3 = r.Next(256);
                n4 = r.Next(256);
                ip = "10." + n2 + "." + n3 + "." + n4;

                if (!lista.Contains(ip))
                {
                    lista.Add(ip);
                }

                sw.WriteLine("   range" + ip + ";");
            }
            sw.WriteLine("}");

            sw.Close();
        }


    }
}
