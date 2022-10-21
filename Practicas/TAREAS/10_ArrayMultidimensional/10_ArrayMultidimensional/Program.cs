using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            #region Menú_1
            int relacion;

            Console.WriteLine("╔════╗");
            Console.WriteLine("║Menú║");
            Console.WriteLine("╚════╝");
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
            Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
            Console.WriteLine("║1-  Relación 1                           ║");
            Console.WriteLine("║2-  Adicionales                          ║");
            Console.WriteLine("║   ...                                   ║");
            Console.WriteLine("║0- Salir                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            relacion = int.Parse(Console.ReadLine());

            while (relacion < 0 || relacion > 2)
            {
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige la relación de ejercicios   │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1-  Relación 1                           ║");
                Console.WriteLine("║2-  Adicionales                          ║");
                Console.WriteLine("║   ...                                   ║");
                Console.WriteLine("║0- Salir                                 ║");
                Console.WriteLine("╚═════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                relacion = int.Parse(Console.ReadLine());
            }

            #endregion

            switch (relacion)
            {
                case 1:
                    {
                        #region Relación_1

                        #region Menú_2

                        Console.ForegroundColor = ConsoleColor.Blue;
                        int ejercicio;

                        Console.Clear();
                        Console.WriteLine("╔════╗");
                        Console.WriteLine("║Menú║");
                        Console.WriteLine("╚════╝");
                        Console.WriteLine("╔═════════════════════════════════════════╗");
                        Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                        Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                        Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                        Console.WriteLine("║1- EscribeArray3x3                       ║");
                        Console.WriteLine("║2- Rellena3x3                            ║");
                        Console.WriteLine("║3- RellenaAleatorio3x3                   ║");
                        Console.WriteLine("║4- sumaArray3x3                          ║");
                        Console.WriteLine("║5- escribeArrayBi                        ║");
                        Console.WriteLine("║6- rellenaAleatorioBi                    ║");
                        Console.WriteLine("║7- rellenaEnordenBi                      ║");
                        Console.WriteLine("║8- sumaArrayBi                           ║");
                        Console.WriteLine("║9- suma2ArraysBi                         ║");
                        Console.WriteLine("║10- CopiaArrayBi                         ║");
                        Console.WriteLine("║11- CopiaArrayBiPro                      ║");
                        Console.WriteLine("║12- RellenaArrayAjedrez                  ║");
                        Console.WriteLine("║13- RellenaDiagonal                      ║");
                        Console.WriteLine("║14- RellenaX                             ║");
                        Console.WriteLine("║15- RellenaCuadros                       ║");
                        Console.WriteLine("║   ...                                   ║");
                        Console.WriteLine("║0- Salir                                 ║");
                        Console.WriteLine("╚═════════════════════════════════════════╝");
                        ejercicio = int.Parse(Console.ReadLine());

                        while (ejercicio < 0 || ejercicio > 15)
                        {
                            Console.Clear();
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                            Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                            Console.WriteLine("║1- EscribeArray3x3                       ║");
                            Console.WriteLine("║2- Rellena3x3                            ║");
                            Console.WriteLine("║3- RellenaAleatorio3x3                   ║");
                            Console.WriteLine("║4- sumaArray3x3                          ║");
                            Console.WriteLine("║5- escribeArrayBi                        ║");
                            Console.WriteLine("║6- rellenaAleatorioBi                    ║");
                            Console.WriteLine("║7- rellenaEnordenBi                      ║");
                            Console.WriteLine("║8- sumaArrayBi                           ║");
                            Console.WriteLine("║9- suma2ArraysBi                         ║");
                            Console.WriteLine("║10- CopiaArrayBi                         ║");
                            Console.WriteLine("║11- CopiaArrayBiPro                      ║");
                            Console.WriteLine("║12- RellenaArrayAjedrez                  ║");
                            Console.WriteLine("║13- RellenaDiagonal                      ║");
                            Console.WriteLine("║14- RellenaX                             ║");
                            Console.WriteLine("║15- RellenaCuadros                       ║");
                            Console.WriteLine("║   ...                                   ║");
                            Console.WriteLine("║0- Salir                                 ║");
                            Console.WriteLine("╚═════════════════════════════════════════╝");
                            ejercicio = int.Parse(Console.ReadLine());
                        }
                        #endregion

                        #region Relación_1_Ejercicios
                        switch (ejercicio)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    int[,] a = { { 1, 0, 12, -1 }, { 7, -3, 2, 5 }, { -5, -2, 2, -9 } };
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    int[,] a = new int[3, 3];
                                    RellenaArrayMult(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    int[,] a = new int[3, 3];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                    int[,] a = new int[3, 3];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    //int[,] a2 = new int[3, 3];
                                    //RellenaArrayMultAleatorio(a2);
                                    //EscribeArrayMult(a2);
                                    //Console.WriteLine();
                                    //EscribeArrayMult(SumaArrayMult(a, a2));
                                    Console.WriteLine(SumaValores(a));
                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    rellenaEnordenBi(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 8:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    //int[,] a2 = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    //RellenaArrayMultAleatorio(a2);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    //EscribeArrayMult(a2);
                                    //Console.WriteLine();
                                    //EscribeArrayMult(sumaArrayBi(a, a2));
                                    Console.WriteLine(SumaValores(a));
                                }
                                break;
                            case 9:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño de los arrays ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    int[,] a2 = new int[n, n2];
                                    int[,] a3 = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    RellenaArrayMultAleatorio(a2);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    EscribeArrayMult(a2);
                                    Console.WriteLine();
                                    EscribeArrayMult(suma2ArraysBi(a, a2, a3));
                                }
                                break;
                            case 10:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño de los arrays ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    int[,] a2 = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    EscribeArrayMult(CopiaArrayBi(a, a2));
                                }
                                break;
                            case 11:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n2]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int n2 = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n2];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    EscribeArrayMult(CopiaArrayBiPro(a));
                                }
                                break;
                            case 12:
                                {
                                    Console.Clear();
                                    int[,] a = new int[8, 8];
                                    RellenaArrayAjedrez(a);
                                    Console.WriteLine();
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 13:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n];
                                    RellenaDiagonal(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 14:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n];
                                    RellenaX(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            case 15:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n];
                                    RellenaCuadros(a);
                                    EscribeArrayMult(a);
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔══════════════════════════════════╗");
                                Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                                Console.WriteLine("╚══════════════════════════════════╝");
                                Environment.Exit(0);
                                break;
                        }
                        #endregion

                        #endregion
                    }
                    break;
                case 2:
                    {
                        #region Adicionales

                        #region Menú_03

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        int ejercicio;

                        Console.Clear();
                        Console.WriteLine("╔════╗");
                        Console.WriteLine("║Menú║");
                        Console.WriteLine("╚════╝");
                        Console.WriteLine("╔═════════════════════════════════════════╗");
                        Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                        Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                        Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                        Console.WriteLine("║1- InvierteBi                            ║");
                        Console.WriteLine("║2- CalculaDeterminante                   ║");
                        Console.WriteLine("║3- CuadradoMagico                        ║");
                        Console.WriteLine("║4-                           ║");
                        Console.WriteLine("║5-                         ║");
                        Console.WriteLine("║6-                     ║");
                        Console.WriteLine("║   ...                                   ║");
                        Console.WriteLine("║0- Salir                                 ║");
                        Console.WriteLine("╚═════════════════════════════════════════╝");
                        ejercicio = int.Parse(Console.ReadLine());

                        while (ejercicio < 0 || ejercicio > 15)
                        {
                            Console.Clear();
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                            Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                            Console.WriteLine("║1- InvierteBi                            ║");
                            Console.WriteLine("║2- CalculaDeterminante                   ║");
                            Console.WriteLine("║3- CuadradoMagico                        ║");
                            Console.WriteLine("║4-                           ║");
                            Console.WriteLine("║5-                         ║");
                            Console.WriteLine("║6-                     ║");
                            Console.WriteLine("║   ...                                   ║");
                            Console.WriteLine("║0- Salir                                 ║");
                            Console.WriteLine("╚═════════════════════════════════════════╝");
                            ejercicio = int.Parse(Console.ReadLine());
                        }

                        #endregion

                        #region Adicionales_Ejercicios

                        switch (ejercicio)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño del array ([n x n]) : ");
                                    int n = int.Parse(Console.ReadLine());
                                    int[,] a = new int[n, n];
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    EscribeArrayMult(InvierteBi(a));

                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    int[,] a = new int[3,3];
                                    Console.WriteLine("Calculamos el siguiente determinante de 3x3 : ");
                                    RellenaArrayMultAleatorio(a);
                                    EscribeArrayMult(a);
                                    Console.WriteLine();
                                    Console.WriteLine("El determinante de la matriz es : " + CalculaDeterminante(a));

                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔══════════════════════════════════╗");
                                Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                                Console.WriteLine("╚══════════════════════════════════╝");
                                Environment.Exit(0);
                                break;
                        }

                        #endregion

                        #endregion
                    }
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("╔══════════════════════════════════╗");
                    Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                    Console.WriteLine("╚══════════════════════════════════╝");
                    Environment.Exit(0);
                    break;
            }
        }
        static double CalculaDeterminante(int[,] a)
        {
            double sarrus = ((a[0, 0] * a[1, 1] * a[2, 2]) +
                             (a[1, 0] * a[2, 1] * a[0, 2]) +
                             (a[0, 1] * a[1, 2] * a[2, 0])) -
                             ((a[0, 2] * a[1, 1] * a[2, 0]) +
                             (a[0, 1] * a[1, 0] * a[2, 2]) +
                             (a[1, 2] * a[2, 1] * a[0, 0]));

            return sarrus;
        }

        static int[,] InvierteBi(int[,] a)
        {
            int[,] a2 = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a2[i, j] = a[j, i]; 
                }
            }

            return a2;
        }

        static void RellenaCuadros(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (i < a.GetLength(0) / 2 && j < a.GetLength(1) / 2 )
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i < a.GetLength(0) / 2 && j < a.GetLength(1))
                        {
                            a[i, j] = 2;
                        }
                        else
                        {
                            if (i >= a.GetLength(0) / 2 && j < a.GetLength(1) / 2)
                            {
                                a[i, j] = 3;
                            }
                            else
                            {
                                a[i, j] = 4;
                            }
                        }
                    }
                }
            }
        }

        static void RellenaX(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i+j == a.GetLength(0)-1)
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 2; 
                        }
                    }
                }
            }
        }

        static void RellenaDiagonal(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i < j)
                        {
                            a[i, j] = 2;
                        }
                        else
                        {
                            a[i, j] = 3;
                        }
                    }
                }
            }
        }

        static void RellenaArrayAjedrez(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        a[i, j] = 0;
                    }
                    else
                    {
                        a[i, j] = 1;
                    }
                }
            }
        }

        static int[,] CopiaArrayBiPro(int[,] a)
        {
            int i, j;
            int[,] a2 = new int[a.GetLength(0), a.GetLength(1)];
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a2[i, j] = a[i, j];
                }
            }
            return a2;
        }

        static int[,] CopiaArrayBi(int[,] a, int[,] a2)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a2[i, j] = a[i, j]; 
                }
            }
            return a2;
        }

        static int SumaValores(int[,] a)
        {
            int i, j, suma = 0;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    suma = a[i, j] + suma;
                }
            }

            return suma;
        }

        static int[,] suma2ArraysBi(int[,] a, int[,] a2, int[,] a3)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a3[i, j] = a[i, j] + a2[i, j];
                }
            }
            return a3;
        }

        static void rellenaEnordenBi(int[,] a)
        {
            int i, j, k=0;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = 1 + k;
                    k++;
                }
            }
        }

        static int[,] SumaArrayMult(int[,] a, int[,] a2)
        {
            int i, j;
            int[,] a3 = new int[3, 3];

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a3[i, j] = a[i, j] + a2[i, j];
                }
            }

            return a3;
        }

        static void RellenaArrayMultAleatorio(int[,] a)
        {
            int i, j;

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Random r = new Random();
                    a[i,j] = r.Next(1, 10 + 1);
                }
            }
        }

        static void RellenaArrayMult(int[,] a)
        {
            int i, j;
            int n;

            Console.WriteLine("Dame los elementos del array");

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Dime el elemento " + i + "," + j);
                    n = int.Parse(Console.ReadLine());
                    a[i, j] = n;
                }
            }
        }

        static void RellenaArrayMultDouble(double[,] a)
        {
            int i, j;
            double n;

            Console.WriteLine("Dame los elementos del array");

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Dime el elemento " + a[i, j]);
                    n = double.Parse(Console.ReadLine());
                    a[i, j] = n;
                }
            }
        }

        static void EscribeArrayMult(int[,] a)
        {
            int i, j;
            Console.Write("╔");

            for (j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("\t");
            }

            Console.WriteLine("╗");
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("║");
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j].ToString().PadLeft(4) + "\t");
                }
                Console.WriteLine("║");
            }
            Console.Write("╚");

            for (j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("\t");
            }
            Console.Write("╝");
        }

    }
}
