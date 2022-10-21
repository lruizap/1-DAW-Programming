using System;

namespace _01_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("╔════╗");
            Console.WriteLine("║Menú║");
            Console.WriteLine("╚════╝");
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║1-  EscribeArray5          16- MinArray                31- ConcatenaArraysPro       ║");
            Console.WriteLine("║2-  EscribeArray           17- MaxArray                32- CopiaArrayPro            ║");
            Console.WriteLine("║3-  LeeArray5              18- NumeroAprobados         33- InsertaEnArray           ║");
            Console.WriteLine("║4-  LeeArray               19- PorEncimaDe             34- BorraDeArray             ║");
            Console.WriteLine("║5-  ponCeros5              20- CuantosCeros            35- Elimina1ElementoArray    ║");
            Console.WriteLine("║6-  ponCero                21- CopiaArray              36- EliminaElementoArray     ║");
            Console.WriteLine("║7-  sumaArray5             22- CopiaArrayInvertido     37- InsertaArrayEnArray      ║");
            Console.WriteLine("║8-  sumaArray              23- SumaArrays              38- SubArray                 ║");
            Console.WriteLine("║9-  mediaArray5            24- RestaArrays             39- RecortaArray             ║");
            Console.WriteLine("║10- mediaArray             25- InvierteArray           40- OrdenaBurbuja            ║");
            Console.WriteLine("║11- RellenaEnOrden         26- ComparaArrays                                        ║");
            Console.WriteLine("║12- RellenaEnOrdenDesc     27- PonNotasArray                                        ║");
            Console.WriteLine("║13- RellenaAleatorio       28- ConcatenaArrays55                                    ║");
            Console.WriteLine("║14- EstaOrdenado           29- ConcatenaArrays                                      ║");
            Console.WriteLine("║15- NumeroImpares          30- Contiene                                             ║");
            Console.WriteLine("║   ...                                                                              ║");
            Console.WriteLine("║0- Salir                                                                            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            opcion = int.Parse(Console.ReadLine());

            while (opcion < 0 || opcion > 40 )
            {
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║1-  EscribeArray5          16- MinArray                31- ConcatenaArraysPro       ║");
                Console.WriteLine("║2-  EscribeArray           17- MaxArray                32- CopiaArrayPro            ║");
                Console.WriteLine("║3-  LeeArray5              18- NumeroAprobados         33- InsertaEnArray           ║");
                Console.WriteLine("║4-  LeeArray               19- PorEncimaDe             34- BorraDeArray             ║");
                Console.WriteLine("║5-  ponCeros5              20- CuantosCeros            35- Elimina1ElementoArray    ║");
                Console.WriteLine("║6-  ponCero                21- CopiaArray              36- EliminaElementoArray     ║");
                Console.WriteLine("║7-  sumaArray5             22- CopiaArrayInvertido     37- InsertaArrayEnArray      ║");
                Console.WriteLine("║8-  sumaArray              23- SumaArrays              38- SubArray                 ║");
                Console.WriteLine("║9-  mediaArray5            24- RestaArrays             39- RecortaArray             ║");
                Console.WriteLine("║10- mediaArray             25- InvierteArray           40- OrdenaBurbuja            ║");
                Console.WriteLine("║11- RellenaEnOrden         26- ComparaArrays                                        ║");
                Console.WriteLine("║12- RellenaEnOrdenDesc     27- PonNotasArray                                        ║");
                Console.WriteLine("║13- RellenaAleatorio       28- ConcatenaArrays55                                    ║");
                Console.WriteLine("║14- EstaOrdenado           29- ConcatenaArrays                                      ║");
                Console.WriteLine("║15- NumeroImpares          30- Contiene                                             ║");
                Console.WriteLine("║   ...                                                                              ║");
                Console.WriteLine("║0- Salir                                                                            ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Elige una opción : ");
                opcion = int.Parse(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 23, 43, 1, -3, 6 };
                        Escribearray5(a);
                    }
                    break;
                case 2:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
                        Escribearray(a);
                    }
                    break;
                case 3:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);
                        Escribearray5(a);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Escribearray(a);
                    }
                    break;
                case 5:
                    {
                        int[] a = new int[5];
                        Escribearray5(a);
                        ponCeros5(a);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        Escribearray(a);
                        ponCero(a);
                    }
                    break;
                case 7:
                    {
                        int[] a = new int[5];
                        sumaArray5(a);

                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        sumaArray(a);

                    }
                    break;
                case 9:
                    {
                        int[] a = new int[5];
                        mediaArray5(a);

                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        mediaArray(a);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        RellenaEnOrden(a);
                        Escribearray(a);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        RellenaEnOrdenDesc(a);
                        Escribearray(a);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        RellenaAleatorio(a);
                        Escribearray(a);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        if (EstaOrdenado(a))
                        {
                            Console.WriteLine("Está ordenado");
                        }
                        else
                        {
                            Console.WriteLine("NO Está ordenado");
                        }
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        NumeroImpares(a);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.Write(MinArray(a));
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.Write(MaxArray(a));
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Dime el número de alumnos");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        NumeroAprobados(a);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        PorEncimaDe(a);

                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        CuantosCeros(a);
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] b = new int[n2];
                        LeeArray(b);
                        if (CopiaArray(a, b))
                        {
                            Escribearray(b);
                        }
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] b = new int[n2];
                        LeeArray(b);
                        if (CopiaArrayInvertido(a, b))
                        {
                            Escribearray(b);
                        }
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        int[] b = new int[n];
                        LeeArray(b);
                        int[] c = new int[n];
                        SumaArrays(a, b, c);
                        Console.Write("La suma es "); Escribearray(c);
                    }
                    break;
                case 24:
                    {
                        while (opcion < 0 || opcion > 3)
                        {
                            Console.Clear(); //Limpiar la pantalla
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔════════════════════════╗");
                            Console.WriteLine("║1-  RestaArray          ║");
                            Console.WriteLine("║2-  MultiplicaArray     ║");
                            Console.WriteLine("║3-  DivideArray         ║");
                            Console.WriteLine("║0- Salir                ║");
                            Console.WriteLine("╚════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("Elige una opción : ");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        switch (opcion)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Dime el tamaño del array");
                                    int n = int.Parse(Console.ReadLine());
                                    int[] a = new int[n];
                                    LeeArray(a);
                                    int[] b = new int[n];
                                    LeeArray(b);
                                    int[] c = new int[n];
                                    RestaArray(a, b, c);
                                    Console.Write("La suma es "); Escribearray(c);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Dime el tamaño del array");
                                    int n = int.Parse(Console.ReadLine());
                                    int[] a = new int[n];
                                    LeeArray(a);
                                    int[] b = new int[n];
                                    LeeArray(b);
                                    int[] c = new int[n];
                                    MultiplicaArray(a, b, c);
                                    Console.Write("La suma es "); Escribearray(c);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Dime el tamaño del array");
                                    int n = int.Parse(Console.ReadLine());
                                    int[] a = new int[n];
                                    LeeArray(a);
                                    int[] b = new int[n];
                                    LeeArray(b);
                                    int[] c = new int[n];
                                    DivideArray(a, b, c);
                                    Console.Write("La suma es "); Escribearray(c);
                                }
                                break;
                            default:
                                Console.WriteLine("╔══════════════════════════════════╗");
                                Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                                Console.WriteLine("╚══════════════════════════════════╝");
                                Environment.Exit(0);
                                break;
                        }
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        InvierteArray(a);
                        Escribearray(a);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        while (n != n2)
                        {
                            Console.WriteLine("Error, elija un tamaño válido");
                            Console.WriteLine("Dime el tamaño del array");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dime el tamaño del segundo array");
                            n2 = int.Parse(Console.ReadLine());
                        }
                        int[] a = new int[n];
                        LeeArray(a);
                        int[] b = new int[n2];
                        LeeArray(b);
                        Console.WriteLine(ComparaArrays(a,b));
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        double n = double.Parse(Console.ReadLine());
                        double[] a = new double[(int)n];
                        bool[] b = new bool[(int)n];
                        LeeArraydouble(a);
                        PonNotasArray(a, b);
                        EscribeArraydouble(a);
                        Escribearraybool(b);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Primer array");
                        int[] a = new int[5];
                        LeeArray(a);
                        Console.WriteLine("Segundo array");
                        int[] b = new int[5];
                        LeeArray(b);
                        int[] c = new int[10];
                        ConcatenaArrays55(a, b, c);
                        Escribearray(c);
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] b = new int[n2];
                        LeeArray(b);
                        int[] c = new int[n + n2];
                        ConcatenaArrays(a, b, c);
                        Escribearray(c);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        RellenaAleatorio(a);
                        Console.WriteLine(Contiene(a));
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] b = new int[n2];
                        LeeArray(b);
                        int[] c;
                        c = ConcatenaArraysPro(a, b);
                        Escribearray(c);
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        int[] b;
                        b = CopiaArrayPro(a);
                        Escribearray(b);
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime la posición que quieres modificar");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el número que quieres insertar");
                        int num = int.Parse(Console.ReadLine());
                        InsertaEnArray(ref a, p, num);
                        Escribearray(a);
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime la posición que quieres borrar");
                        int p = int.Parse(Console.ReadLine());
                        BorraDeArray(ref a, p);
                        Escribearray(a);
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el número que quieres borrar");
                        int p = int.Parse(Console.ReadLine());
                        Elimina1ElementoArray(ref a, p);
                        Escribearray(a);

                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el número que quieres borrar");
                        int p = int.Parse(Console.ReadLine());
                        EliminaElementoArray(ref a, p);
                        Escribearray(a);
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime el tamaño del segundo array");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] b = new int[n2];
                        LeeArray(b);
                        Console.WriteLine("Dime la posición en la que quieres insertar el segundo array");
                        int p = int.Parse(Console.ReadLine());
                        InsertaArrayEnArray(ref a, p, b);
                        Escribearray(a);
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime la posicion desde la que quieres conocer el array");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime la segunda posicion desde la que quieres conocer el array");
                        int p2 = int.Parse(Console.ReadLine());
                        int[] b;
                        b = SubArray(a, p, p2);
                        Escribearray(b);

                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime la posicion desde la que quieres conocer el array");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime la segunda posicion desde la que quieres conocer el array");
                        int p2 = int.Parse(Console.ReadLine());
                        RecortaArray(ref a, p, p2);
                        Escribearray(a);
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        OrdenaBurbuja(a);
                        Escribearray(a);
                    }
                    break;
                default:
                    Console.WriteLine("╔══════════════════════════════════╗");
                    Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                    Console.WriteLine("╚══════════════════════════════════╝");
                    Environment.Exit(0);
                    break;
            }
        }

        static void RecortaArray(ref int[] a, int p, int p2)
        {
            int tama;
            tama = p2 - p;

            for (int i = 0; i < tama+1; i++)
            {
                a[i] = a[p + i];
            }
            Array.Resize(ref a, (p2-p)+1);
        } // 39

        static void OrdenaBurbuja(int[] a)
        {
            int temp;

            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
        } // 40 un array de enteros y lo ordenará mediante la ordenación de la burbuja.La ordenación de la burbuja funciona de la siguiente forma:
          // • Si el array tiene N elementos, se realizarán N-1 pasadas(por ejemplo, para unarray de 5 elementos tendremos que realizar 4 pasadas para que quede ordenado).
          // • En cada pasada, iremos recorriendo el array de principio a fin comprobando los números por parejas(por ejemplo: el primer y segundo número, el segundo y el tercero, etc.).
          // • Si la pareja de números está en orden(o sea, el primero es menor que el segundo) la dejamos como está y si está desordenada, los intercambiamos.

        static int[] SubArray(int[] a, int pos1, int pos2)
        {
            int tama;
            tama = pos2 - pos1;

            int[] b = new int[tama + 1];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[pos1 + i];
            }
            return b;
        } // 38, a la que le pasas un array y dos posiciones. La función te devuelve otro array que contiene los datos comprendidos entre ambas posiciones

        static void InsertaArrayEnArray(ref int[] a, int p, int[] b)
        {
            int alength = a.Length;

            if (p < a.Length && p >= 0)
            {
                Array.Resize(ref a, a.Length + b.Length);

                for (int i = a.Length-1; i >= p+b.Length; i--)
                {
                    a[i] = a[i - b.Length];
                }

                for (int i = p; i < p+b.Length; i++)
                {
                    a[i] = b[i - p];
                }

                //for(int i = 0; i< b.Length; i++)
                //{
                //    a[i + p] = b[i];
                //}
            }
            else
            {
                Console.WriteLine("No existe esa posición en el array.");
            }
        } // 37

        static void EliminaElementoArray(ref int[] a, int elemento)
        {
            int i, j, tama;
            j = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == elemento )
                {                    
                    j++;
                }
                else
                {
                    a[i-j] = a[i];
                }
            }
            tama = a.Length - j;
            Array.Resize(ref a, tama);
        } // 36

        static void Elimina1ElementoArray(ref int[] a, int elemento)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (elemento == a[i])
                {
                    BorraDeArray(ref a, i);
                    break;
                }
            }
  
        } // 35

        static void BorraDeArray(ref int[] a, int p)
        {
            int i, tama;
            for (i = p; i < a.Length-1; i++)
            {
                a[i] = a[i+1];
            }
            tama = a.Length - 1;
            Array.Resize(ref a, tama);
        } // 34

        static void InsertaEnArray(ref int[] a, int p, int num)
        {
            int i, tama;
            tama = a.Length + 1;
            Array.Resize(ref a, tama);
            for (i = tama-1; i > p; i--)
            {
                a[i] = a[i-1];
            }
            a[p] = num;
            
        } // 33

        static int[] CopiaArrayPro(int[] a)
        {
            int i;
            int[] b = new int[a.Length];
            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        } // 32

        static int[] ConcatenaArraysPro(int[] a, int[] b)
        {
            int i;
            int [] c = new int[a.Length + b.Length];
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }

            return c;

        } // 31

        static bool Contiene(int[] a)
        {
            int n, i;
            bool v;
            v = true;
            Console.WriteLine("Dime un número entre el 1 y el 10");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < a.Length-1; i++)
            {
                if (n != a[i])
                {
                    v = false;
                }
            }

            return v;
        } // 30

        static void ConcatenaArrays(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for (i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }
        } // 29

        static void ConcatenaArrays55(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[i-5]; 
                }
            }
        } // 28

        static void LeeArraydouble(double[] a)
        {
            int i;
            double n;

            Console.WriteLine("Dame los elementos del array");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = double.Parse(Console.ReadLine());
                a[i] = n;
            }

        }

        static void Escribearraybool(bool[] a)
        {
            int i;
            if (a.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < a.Length - 1; i++)
                {
                    Console.Write(a[i] + "; ");
                }
                Console.Write(a[a.Length - 1] + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }

        }

        static void EscribeArraydouble(double[] a)
        {
            int i;
            if (a.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < a.Length - 1; i++)
                {
                    Console.Write(a[i] + "; ");
                }
                Console.Write(a[a.Length - 1] + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }

        }

        static bool PonNotasArray(double[] a, bool[] b)
        {
            int i;
            bool v;
            v = true;
            for (i = 0; i < a.Length; i++)
            {
                while (a[i] < 0 || a[i] > 10)
                {
                    Console.WriteLine("Error, escriba el valor " + i + " de nuevo");
                    a[i] = int.Parse(Console.ReadLine());
                }

                if (a[i] >= 5)
                {
                    v = true;
                    b[i] = true;

                }
                else
                {
                    v = false;
                    b[i] = false;
                }
            }
            return v;
        } // 27

        static bool ComparaArrays(int[] a, int[] b)
        {
            int i;
            bool v;
            v = true;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    v = false;
                }
            }

            return v;
        } // 26

        static void InvierteArray(int[] a) 
        {
            int i, cont, temp;
            temp = 0;
            cont = a.Length-1;

            // while(i < cont)
            // {
            //      temp = a[i];
            //      a[i] = a[cont];
            //      a[cont] = temp;
            //
            //      i++;
            //      cont--;

            // }

            for (i = 0; i < a.Length / 2 ; i++)
            {
                temp = a[i];
                a[i] = a[cont];
                a[cont] = temp;
                cont--;
                
            }
        } // 25

        static void DivideArray(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] / b[i];
            }
        } // 24

        static void MultiplicaArray(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] * b[i];
            }
        } // 24

        static void RestaArray(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] - b[i];
            }
        } //24

        static void SumaArrays(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
        } // 23

        static bool CopiaArrayInvertido(int[] a, int[] b)
        {
            int i, cont;
            cont = a.Length-1;
            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[cont];
                    cont--;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Error, comeme los huevos");
                return false;
            }
        } // 22

        static bool CopiaArray(int[] a, int[] b)
        {
            int i;
            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
                return true;
            }
            else
            {
                Console.WriteLine("Error, comeme los huevos");
                return false;
            }
        } // 21

        static void CuantosCeros(int[] a)
        {
            int i, cont;
            cont = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        } // 20

        static void PorEncimaDe(int[] a)
        {
            int i, cont, n;
            cont = 0;
            Console.WriteLine("Dime el valor máximo del array");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < a.Length; i++)
            {

                if (a[i] > n)
                {
                    cont++;
                }  
            }
            Console.WriteLine(cont);

        } // 19

        static void NumeroAprobados(int[] a)
        {
            int i, cont, susp;
            cont = 0;
            susp = 0;
            
            for (i = 0; i < a.Length; i++)
            {
                while (a[i] < 0 || a[i] > 10)
                {
                    Console.WriteLine("Error, escriba el valor " + i + " de nuevo");
                    a[i] = int.Parse(Console.ReadLine());
                }

                if (a[i] < 5)
                {
                    susp++;
                }
                else
                {
                    cont++;
                }
            }
            Console.WriteLine("Hay " + cont + " aprobados y " + susp + " suspensos");
        } // 18

        static int MaxArray(int[] a)
        {
            int i, max;
            max = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        } // 17

        static int MinArray(int[] a) 
        {
            int i, min;
            min = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        } // 16 

        static void NumeroImpares(int[] a)
        {
            int i, cont;
            cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {

                }
                else
                {
                    cont++;
                }
            }
            Console.WriteLine("Hay " + cont + " números impares");
        } // 15

        static bool EstaOrdenado(int[] a)
        {
            int i;
            bool v;
            v = true;
            for (i = 0; i < a.Length -1; i++)
            {
                if (a[i] > a[i+1])
                {
                    v = false;
                }
               
            }
            return v;
        } // 14

        static void RellenaAleatorio(int[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                Random r = new Random();
                a[i] = r.Next(1, 10 + 1);
            }
            
        } // 13

        static void RellenaEnOrdenDesc(int[] a)
        {
            int i, cont;
            cont = a.Length;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = cont;
                cont--;
            }
        } // 12

        static void RellenaEnOrden(int[] a)  // 11
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = 1 + i;
            }
        }

        static void mediaArray(int[] a)
        {
            int i, n, suma, media;
            suma = 0;

            Console.WriteLine("Dame los elementos del array");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
                suma = suma + a[i];
            }
            media = (suma / a.Length);
            Console.WriteLine("La media de los valores es de : " + media);

        } // 10

        static void mediaArray5(int[] a)
        {
            int media, i, n, suma;
            suma = 0;

            Console.WriteLine("Dame los elementos del array de tamaño 5");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
                suma = suma + a[i];
            }
            media = (suma / 5);
            Console.WriteLine("La media de los valores es de : " + media);
        } // 9

        static void sumaArray(int[] a)
        {
            int i, n, suma;
            suma = 0;

            Console.WriteLine("Dame los elementos del array");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
                suma = suma + a[i];
            }
            Console.WriteLine("La suma de los valores es de : " + suma);
        } // 8

        static void sumaArray5(int[] a)
        {
            int i, n, suma;
            suma = 0;

            Console.WriteLine("Dame los elementos del array de tamaño 5");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
                suma = suma + a[i];
            }
            Console.WriteLine("La suma de los valores es de : " + suma);
        } // 7

        static void ponCero(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        } // 6

        static void ponCeros5(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            
        } // 5

        static void LeeArray(int[] a) 
        {
            int i, n;

            Console.WriteLine("Dame los elementos del array");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
            }

        } // 4 

        static void LeeArray5(int[] a)
        {
            int i, n;

            Console.WriteLine("Dame los elementos del array de tamaño 5");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Dime el elemento " + i + " : ");
                n = int.Parse(Console.ReadLine());
                a[i] = n;
            }

        } // 3

        static void Escribearray(int[] a)
        {
            int i;
            if (a.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < a.Length-1; i++)
                {
                    Console.Write(a[i] + ", ");
                }
                Console.Write(a[a.Length - 1] + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
            
        } // 2 

        static void Escribearray5(int[] a) 
        {
            int i;
            Console.Write("[");
            for (i = 0; i < 4; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.Write(a[4] + "]");
        } // 1
    }
}
