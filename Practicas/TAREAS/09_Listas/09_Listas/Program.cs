using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Listas
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
            Console.WriteLine("║2-  Relación 2                           ║");
            Console.WriteLine("║3-  Adicionales                          ║");
            Console.WriteLine("║   ...                                   ║");
            Console.WriteLine("║0- Salir                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            relacion = int.Parse(Console.ReadLine());

            while (relacion < 0 || relacion > 3)
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
                Console.WriteLine("║2-  Relación 2                           ║");
                Console.WriteLine("║3-  Adicionales                          ║");
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
                        Console.WriteLine("║1- LeeLista                              ║");
                        Console.WriteLine("║2- LeeListaN                             ║");
                        Console.WriteLine("║3- EscribeLista                          ║");
                        Console.WriteLine("║4- EliminaNegativo                       ║");
                        Console.WriteLine("║5- ClasificaNumeros                      ║");
                        Console.WriteLine("║6- EliminaRepetidos                      ║");
                        Console.WriteLine("║7- OrdenaListaSeleccion                  ║");
                        Console.WriteLine("║8- OrdenaListaInsercion                  ║");
                        Console.WriteLine("║   ...                                   ║");
                        Console.WriteLine("║0- Salir                                 ║");
                        Console.WriteLine("╚═════════════════════════════════════════╝");
                        ejercicio = int.Parse(Console.ReadLine());

                        while (ejercicio < 0 || ejercicio > 8)
                        {
                            Console.Clear();
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                            Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                            Console.WriteLine("║1- LeeLista                              ║");
                            Console.WriteLine("║2- LeeListaN                             ║");
                            Console.WriteLine("║3- EscribeLista                          ║");
                            Console.WriteLine("║4- EliminaNegativo                       ║");
                            Console.WriteLine("║5- ClasificaNumeros                      ║");
                            Console.WriteLine("║6- EliminaRepetidos                      ║");
                            Console.WriteLine("║7- OrdenaListaSeleccion                  ║");
                            Console.WriteLine("║8- OrdenaListaInsercion                  ║");
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
                                    List<int> l = new List<int>();
                                    LeeLista(l);
                                    EscribeLista(l);

                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño de la lista");
                                    int n = int.Parse(Console.ReadLine());
                                    List<int> l = new List<int>();
                                    LeeListaN(l, n);
                                    EscribeLista(l);

                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño de la lista");
                                    int n = int.Parse(Console.ReadLine());
                                    List<int> l = new List<int>();
                                    LeeListaN(l, n);
                                    EscribeLista(l);

                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime el tamaño de la lista");
                                    int n = int.Parse(Console.ReadLine());
                                    List<int> l = new List<int>();
                                    LeeListaN(l, n);
                                    EliminaNegativos(l);
                                    EscribeLista(l);
                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, -4, -5, -6, -7, -8, 0, 7, 8 };
                                    List<int> l2 = new List<int>();
                                    List<int> l3 = new List<int>();
                                    ClasificaNumeros(l, l2, l3);
                                    EscribeLista(l);
                                    EscribeLista(l2);
                                    EscribeLista(l3);
                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 1, 1, 1, 2, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10, 10 };
                                    EliminaRepetidos(l);
                                    EscribeLista(l);
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 5, 8, -4, -5, -6, -7, -8, 0, 7, 4 };
                                    OrdenaListaSeleccion(l);
                                    EscribeLista(l);
                                }
                                break;
                            case 8:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 5, 8, -4, -5, -6, -7, -8, 0, 7, 4 };
                                    OrdenaListaInsercion(l);
                                    EscribeLista(l);
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
                        #region Relación_2

                        #region Menú_3

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
                        Console.WriteLine("║1- OrdenaListaPalabras                   ║");
                        Console.WriteLine("║2- OrdenaListaPalabras2                  ║");
                        Console.WriteLine("║3- InsertaArrayEnArrayPro                ║");
                        Console.WriteLine("║4- SorteoBonoloto                        ║");
                        Console.WriteLine("║5- EliminaRepetidos2                     ║");
                        Console.WriteLine("║6- UnionListas                           ║");
                        Console.WriteLine("║7- InterseccionListas                    ║");
                        Console.WriteLine("║8- DesordenaLista                        ║");
                        Console.WriteLine("║9- ModaLista                             ║");
                        Console.WriteLine("║10- PuntuacionesTrampolin                ║");
                        Console.WriteLine("║   ...                                   ║");
                        Console.WriteLine("║0- Salir                                 ║");
                        Console.WriteLine("╚═════════════════════════════════════════╝");
                        ejercicio = int.Parse(Console.ReadLine());

                        while (ejercicio < 0 || ejercicio > 10)
                        {
                            Console.Clear();
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                            Console.WriteLine("║ │   Elige un ejercicio                │ ║");
                            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                            Console.WriteLine("║1- OrdenaListaPalabras                   ║");
                            Console.WriteLine("║2- OrdenaListaPalabras2                  ║");
                            Console.WriteLine("║3- InsertaArrayEnArrayPro                ║");
                            Console.WriteLine("║4- SorteoBonoloto                        ║");
                            Console.WriteLine("║5- EliminaRepetidos2                     ║");
                            Console.WriteLine("║6- UnionListas                           ║");
                            Console.WriteLine("║7- InterseccionListas                    ║");
                            Console.WriteLine("║8- DesordenaLista                        ║");
                            Console.WriteLine("║9- ModaLista                             ║");
                            Console.WriteLine("║10- PuntuacionesTrampolin                ║");
                            Console.WriteLine("║   ...                                   ║");
                            Console.WriteLine("║0- Salir                                 ║");
                            Console.WriteLine("╚═════════════════════════════════════════╝");
                            ejercicio = int.Parse(Console.ReadLine());
                        }
                        #endregion

                        #region Relación_2_Ejercicios
                        switch (ejercicio)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    List<string> l = new List<string> { "Escribe", "la", "función", "OrdenaListaPalabras", "a", "la", "que", "le", "pasas", "una", "lista", "de", "cadenas" };
                                    EscribeListaString(l);
                                    OrdenaListaPalabras(l);
                                    EscribeListaString(l);
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    List<string> l = new List<string> { "Escribe", "la", "función", "OrdenaListaPalabras", "a", "la", "que", "le", "pasas", "una", "lista", "de", "cadenas" };
                                    EscribeListaString(l);
                                    OrdenaListaPalabras2(l);
                                    EscribeListaString(l);
                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                                    List<int> l2 = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                                    EscribeLista(l);
                                    EscribeLista(l2);
                                    Console.WriteLine("Dime una posición del array");
                                    int p = int.Parse(Console.ReadLine());
                                    while (p < 0 || p > 10)
                                    {
                                        Console.WriteLine("Error, escriba una posición válida");
                                        p = int.Parse(Console.ReadLine());
                                    }
                                    EscribeLista(InsertaArrayEnArrayPro(l, l2, p));
                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                    List<int> numeros = new List<int>(GenerarLista(1, 49));
                                    EscribeLista(SorteoBonoloto(numeros));

                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                    List<int> n = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 6, 7, 12, 1, 2, 2, 0, 9, 8, 112 };
                                    EscribeArrays(EliminaRepetidos2(n));

                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 6, 7, 12, 1, 2, 2, 0, 9, 8, 112 };
                                    List<int> l2 = new List<int> { 1, 4, 5, 3, 7, 5, 9, 15, 456, 14};
                                    EscribeLista(UnionListas(l, l2));
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 6, 7, 12, 1, 2, 2, 0, 9, 8, 112 };
                                    List<int> l2 = new List<int> { 1, 4, 5, 3, 7, 5, 9, 15, 456, 14 };
                                    EscribeLista(InterseccionListas(l,l2));
                                }
                                break;
                            case 8:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
                                    EscribeLista(DesordenaLista(l));
                                }
                                break;
                            case 9:
                                {
                                    Console.Clear();
                                    List<int> l = new List<int> { 1, 2, 3, 1, 4, 5, 6, 4, 4 };
                                    Console.WriteLine(ModaLista(l));
                                }
                                break;
                            case 10:
                                {
                                    Console.Clear();
                                    List<double> l = new List<double> { 3, 4, 5, 6, 4, 4, 10 };
                                    Console.WriteLine("La nota del salto es de : " + PuntuacionesTrampolin(l));
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
        #region Funciones_02

        static double PuntuacionesTrampolin(List<double> l)
        {
            double suma = 0;
            bool v = true;

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < 0 || l[i] > 10)
                {
                    v = false;
                    i = l.Count;
                }
            }

            if (l.Count == 7 && v)
            {
                l.Remove(l.Min());
                l.Remove(l.Min());
                l.Remove(l.Max());
                l.Remove(l.Max());
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            for (int i = 0; i < l.Count; i++)
            {
                suma = suma + l[i];
            }

            return suma;
        }

        static string ModaLista(List<int> l)
        {
            string s = "";
            int max = l[0], maxVeces = 0;
            int i = 0, numVeces = 0, j = 0;

            while (i < l.Count)
            {
                if (l[j] == l[i])
                {
                    numVeces++;
                    j++;
                }

                if (numVeces > maxVeces)
                {
                    max = l[i];
                    maxVeces = numVeces;
                }

                i++;
            }

            return s = "El número más alto es : " + max + " y sale un total de : " + maxVeces;
        }

        static List<int> DesordenaLista(List<int> l)
        {
            List<int> result = new List<int>();
            Random r = new Random();
            int i;

            while (l.Count > 0)
            {
                i = r.Next(0, l.Count);
                result.Add(l[i]);
                l.RemoveAt(i);
            }

            return result;
        }

            static List<int> InterseccionListas(List<int> l, List<int> l2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (l2.Contains(l[i]) && !result.Contains(l[i]))
                {
                    result.Add(l[i]);
                }
            }

            return result;
        }

        static List<int> UnionListas(List<int> l, List<int> l2) 
        {
            List<int> result = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (!result.Contains(l[i]))
                {
                    result.Add(l[i]);
                }
            }

            for (int i = 0; i < l2.Count; i++)
            {
                if (!result.Contains(l2[i]))
                {
                    result.Add(l2[i]);
                }
            }

            return result;
        }

        static int[] EliminaRepetidos2(List<int> l)
        {
            int i;
            List<int> l2 = new List<int>();

            for (i = 0; i < l.Count; i++)
            {
                if (!l2.Contains(l[i]))
                {
                    l2.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(l2);

            return l.ToArray();
        }

        static void EscribeArrays(int[] a)
        {
            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

            Console.WriteLine(result);
        }

        static List<int> SorteoBonoloto(List<int> numeros)
        {
            List<int> result = new List<int>();
            int i, temp;
            Random random = new Random();

            for (i = 0; i < 6; i++)
            {
                temp = random.Next(0, numeros.Count);

                result.Add(numeros[temp]);
                numeros.RemoveAt(temp);
            }

            return result;
        } // 12

        static List<int> GenerarLista(int a, int b)
        {
            int temp;
            List<int> result = new List<int>();

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                result.Add(i);
            }

            return result;
        }

            static List<int> InsertaArrayEnArrayPro(List<int> l, List<int> l2, int p)
        {
            List<int> l3 = new List<int> (l.Count+l2.Count);

            for (int i = 0; i < l.Count; i++)
            {
                l3.Add(l[i]);

                if (i == p)
                {
                    for (int j = 0; j < l2.Count; j++)
                    {
                        l3.Add(l2[j]);
                    }  
                }
            }

            return l3;
        } // 11

        static void OrdenaListaPalabras2(List<string> l)
        {
            string min;
            List<string> l2 = new List<string>();
            string[] c = l.ToArray();
            while (l.Count > 0)
            {
                min = Minimo(l);
                l2.Add(min);
                l.Remove(min);
            }
            l.AddRange(l2);
        } // 10

        static string Minimo(List<string> l)
        {
            string min = l[0];
            int i;

            for (i = 0; i < l.Count; i++)
            {
                if (min.Length > l[i].Length)
                {
                    min = l[i];
                }    
            }
            return min;
        }

        static void OrdenaListaPalabras(List<string> l)
        {
            //l.Sort();

            string min;
            List<string> l2 = new List<string>();
            string[] c = l.ToArray();
            while (l.Count>0)
            {
                min = l.Min();
                l2.Add(min);
                l.Remove(min);
            }
            l.AddRange(l2);
            
        } // 9

        static void EscribeListaString(List<string> l)
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
        }

        static void EscribeListaDouble(List<double> l)
        {
            int i;
            if (l.Count > 0)
            {
                Console.Write("< ");
                for (i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + "; ");
                }
                Console.WriteLine(l[l.Count - 1] + " >");
            }
            else
            {
                Console.WriteLine("<>");
            }
        }

        #endregion

        #region Funciones_01

        static void OrdenaListaInsercion(List<int> ol)
        {
            //List<int> l2 = new List<int>();
            //int i, j, min;

            //for (i = 0; i < l.Count; i++)
            //{
            //    min = l.Min();
            //    l2.Add(min);
            //    l.Remove(min);
            //    i--;
            //}
            //l.Clear();

            //for (i = 0; i < l2.Count; i++)
            //{
            //    l.Add(l2[i]);
            //}

            int n;
            bool insertado;
            List<int> resultado = new List<int>();
            for (int i = 0; i < ol.Count; i++)
            {
                n = ol[i]; // 20

                insertado = false;
                // 
                for (int j = 0; j < resultado.Count; j++)
                {
                    if (n < resultado[j])
                    {
                        resultado.Insert(j, n);
                        insertado = true;
                        break;
                    }
                }
                if (insertado == false)
                {
                    resultado.Add(n);
                }
            }
            ol.Clear();
            ol.AddRange(resultado);

        } // 8

        static void OrdenaListaSeleccion(List<int> l)
        {
            int i;
            List<int> l2 = new List<int>();

            for (i = 0; i < l.Count; i++)
            {
                l2.Add(l.Min());
                l.Remove(l.Min());
                i--;
            }
            l.Clear();
            for (i = 0; i < l2.Count; i++)
            {
                l.Add(l2[i]);
            }
        } // 7

        static void EliminaRepetidos(List<int> l)
        {
            int i;
            List<int> l2 = new List<int>();

            for (i = 0; i < l.Count; i++)
            {
                if (!l2.Contains(l[i]))
                {
                    l2.Add(l[i]);
                }
            }
            l.Clear();
            for (i = 0; i < l2.Count; i++)
            {
                l.Add(l2[i]);
            }
        } // 6

        static void ClasificaNumeros(List<int> l, List<int> l2, List<int> l3)
        {
            int i;

            for (i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    l2.Add(l[i]);
                }
                else
                {
                    l3.Add(l[i]);
                }
            }
            l2.Sort();
            l3.Sort();
        } // 5

        static void EliminaNegativos(List<int> l)
        {
            // l.RemoveAll(p => p < 0);

            int i;

            for (i = 0; i < l.Count; i++)
            {
                if (l[i] < 0)
                {
                    l.RemoveAt(i);
                    i--;
                }
            }

        } // 4

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
        } // 3

        static void LeeListaN(List<int> l , int n)
        {
            int i, n2;

            if (n > 0)
            {
                Console.WriteLine("Dame los elementos de la lista");
                for (i = 0; i < n; i++)
                {
                    Console.Write("Dime el elemento " + i + " : ");
                    n2 = int.Parse(Console.ReadLine());
                    l.Add(n2);
                }
            }
            else
            {
                n = 0;
            }

        } // 2

        static void LeeLista(List<int> l)
        {
            int i, n;

            Console.WriteLine("Dame los elementos de la lista");
            for (i = 0; i < l.Count + 1; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());

                if (n == -1)
                {
                    break;
                }

                l.Add(n);
            }
        } // 1

        #endregion

    }
}
