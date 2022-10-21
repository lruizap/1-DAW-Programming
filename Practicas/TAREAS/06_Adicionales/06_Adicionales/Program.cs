using System;

namespace _06_Adicionales
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
            Console.WriteLine("║ │   Elige el ejercicio                │ ║");
            Console.WriteLine("║ └─────────────────────────────────────┘ ║");
            Console.WriteLine("║1- IntercambiaParImpar                   ║");
            Console.WriteLine("║2- CompruebaTarjeta                      ║");
            Console.WriteLine("║3- TailArray                             ║");
            Console.WriteLine("║4- Detecta5                              ║");
            Console.WriteLine("║5- CalculaNPrimos                        ║");
            Console.WriteLine("║   ...                                   ║");
            Console.WriteLine("║0- Salir                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Elige una opción : ");
            relacion = int.Parse(Console.ReadLine());

            while (relacion < 0 || relacion > 10)
            {
                Console.Clear();
                Console.WriteLine("╔════╗");
                Console.WriteLine("║Menú║");
                Console.WriteLine("╚════╝");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║ ┌─────────────────────────────────────┐ ║");
                Console.WriteLine("║ │   Elige el ejercicio                │ ║");
                Console.WriteLine("║ └─────────────────────────────────────┘ ║");
                Console.WriteLine("║1- IntercambiaParImpar                   ║");
                Console.WriteLine("║2- CompruebaTarjeta                      ║");
                Console.WriteLine("║3- TailArray                             ║");
                Console.WriteLine("║4- Detecta5                              ║");
                Console.WriteLine("║5- CalculaNPrimos                        ║");
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
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine(CompruebaTarjeta(a));
                    }
                    break;
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        IntercambiaParImpar(a);
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Console.WriteLine("Dime la posicion");
                        int p = int.Parse(Console.ReadLine());
                        Escribearray(TailArray(a, p));
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];
                        LeeArray(a);
                        Escribearray(a);
                        Console.WriteLine(Detecta5(a));
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime hasta donde quieres saber");
                        int p = int.Parse(Console.ReadLine());
                        Escribearraybool(CalculaNPrimos(p));
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("Dime el tamaño del array");
                        int n = int.Parse(Console.ReadLine());
                        double[] a = new double[n];
                        LeeArraydouble(a);
                        EscribeArrayNotas(a); 
                        EscribeArrayDouble(a);
                    }
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("╔══════════════════════════════════╗");
                    Console.WriteLine("║Pulse cualquier tecla para cerrar ║");
                    Console.WriteLine("╚══════════════════════════════════╝");
                    Environment.Exit(0);
                    break;
            }
        }

        static double[] RedondeaArray(double[] a)
        {
            /*
                Escribe dos funciones: RedondeaArray y DecimalesArray. A la función RedondeaArray le pasaremos un array de double y nos devolverá otro array de double en el que a los números le quitamos la parte decimal.
                
                Ej.: [1.56, 2.75, 3, 9.9] => [1, 2, 3, 9]
                
                A la función DecimalesArray le pasaremos un array de double y nos devolverá otro array de double en el que aparecerán solamente las partes decimales de los números.
                
                Ej.: [1.56, 2.75, 3, 9.9] => [0.56, 0.75, 0, 0.9] 
            */

            double[] result = new double[a.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Math.Floor(a[i]);
            }

            return result;
        }

        static void EliminaConcurrencias(ref int[] a, int number)
        {
            bool first = false;
            int counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == number)
                {
                    if (!first)
                    {
                        first = true;
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    a[i - counter] = a[i];
                }
            }

            Array.Resize(ref a, a.Length - counter);
        }

        static void CopiaArray(int[] a, int[] b)
        {
            //Escribe una función “CopiaArray” a la que le pasas dos arrays por parámetro (array1 y array2, por ejemplo) del mismo tamaño(se debería comprobar dentro de la función). La función copiara el contenido del primer array al segundo array.
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen la misma longitud.");
            }
        }

        //static double[] RedondeaArray(double[] a)
        //{
        //    /*
        //        Escribe dos funciones: RedondeaArray y DecimalesArray. A la función RedondeaArray le pasaremos un array de double y nos devolverá otro array de double en el que a los números le quitamos la parte decimal.

        //        Ej.: [1.56, 2.75, 3, 9.9] => [1, 2, 3, 9]

        //        A la función DecimalesArray le pasaremos un array de double y nos devolverá otro array de double en el que aparecerán solamente las partes decimales de los números.

        //        Ej.: [1.56, 2.75, 3, 9.9] => [0.56, 0.75, 0, 0.9] 
        //    */

        //    double[] result = new double[a.Length];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = Math.Floor(a[i]);
        //    }

        //    return result;
        //}

        static int[] SeparaNegativosPositivos(int[] a)
        {
            /*
            Escribe la función SeparaNegativosPositivos a la que le pasamos un array de enteros y nos devolverá otro array de enteros con el resultado.
            Esta función deberá separar los números negativos y positivos que hay dentro del array, de manera que los negativos queden al principio y los positivos queden al final, pero manteniendo el orden original de éstos. El array original no debe sufrir modificaciones.
            Ej.: 
                [5, 2, -1, -2] -> [-1, -2, 5, 2]
                [4, -5, 1, -8, 2, -1] -> [-5, -8, -1, 4, 1, 2] 
            */

            int i = 0, j = 0;
            int[] result = new int[a.Length];

            for (; i < result.Length; i++)
            {
                if (a[i] < 0)
                {
                    result[j] = a[i];
                    j++;
                }
            }

            for (i = 0; i < result.Length; i++)
            {
                if (a[i] >= 0)
                {
                    result[j] = a[i];
                    j++;
                }
            }

            return result;
        }

        static void TroceaArray(int[] a, int[] b, int[] c)
        {
            /*
            Escribe la función TroceaArray a la que le pasamos tres arrays a, b y c de forma que el tamaño de a debe ser igual a la suma de los tamaños de b y c (por ejemplo, a puede tener tamaño 10, b ser de tamaño 6 y c de tamaño 4). La función copiará números de a a b mientras quepan en b y el resto los pondrá en c (es como ConcatenaArray, pero al revés).
            Ej.: a = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], la función rellenaría los otros dos arrays con los valores: b = [1, 2, 3, 4, 5, 6] y c = [7, 8, 9, 10] 
            */

            int i = 0, j = 0;

            if (a.Length == (b.Length + c.Length))
            {
                for (; i < b.Length; i++)
                {
                    b[i] = a[i];
                }

                for (; j < c.Length; j++)
                {
                    c[j] = a[i];
                    i++;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Los arrays b y c no tienen un tamaño adecuado.");
            }
        }

        static void NumerosPrimosPro(int max)
        {
            /*
                Escribe la función NumerosPrimosPro que nos calculará los números primos entre 1 y otro número (para probarlo, nos vale con 1000). Esta función usará un algoritmo más avanzado que el que hemos visto con anterioridad y que es mucho más eficiente a la hora de calcular muchos números primos.
                
                El funcionamiento es el siguiente (para el ejemplo del 1 al 1000): 
                    • Creamos un array de 1001 elementos (por el cero).
                    • Empezamos en la posición 2 del array y vamos haciendo lo siguiente:
                        o Si en esta posición hay un 0 (que es lo que había al principio), añadimos esta posición a una lista de números primos.
                        o Si había un 0, además, tenemos que ir “tachando” todos los múltiplos de ese número primo poniendo otro valor en esas posiciones (por ejemplo, un -1). En el caso del 2, que sería el primero, pondríamos un -1 en la posición 4, 6, 8, 10, 12, etc., y así hasta llegar al 1000.
                        o Si en la posición hay un -1, eso es que este número ya era múltiplo de uno anterior, así que no hacemos nada y pasamos al siguiente.
                    • Al final, devolveremos la lista de números primos que hemos ido recopilando.
               
                Para comprobarlo, mostrar los números primos entre 1 y 1000 por pantalla y escribir cuántos números son (empieza por 2, 3, 5, 7... acaba por 983, 991, 997 y son 168 números primos en total).
            */

            int[] a = new int[max + 1];

            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    Console.WriteLine(i);
                    for (int j = i + i; j < a.Length; j += i)
                    {
                        a[j] = -1;
                    }
                }
            }
        }

        static int[] EliminaRepetidos(int[] a)
        {
            //Escribe la función EliminaRepetidos a la que le pasas un array y te devuelve otro array en el que se han eliminado los elementos que estén repetidos.
            //Ej: [1, 5, 9, 2, 3, 4, 1, 1, 2] => [1, 5, 9, 2, 3, 4]

            int[] copy = new int[a.Length];

            CopiaArray(a, copy);

            for (int i = 0; i < copy.Length; i++)
            {
                EliminaConcurrencias(ref copy, a[i]);
            }

            return copy;
        }

        static string QuitaAcentos(string s)
        {
            //Escribe la función “QuitaAcentos” a la que le pasas una cadena con caracteres acentuados y te devuelve la cadena con los acentos quitados(esto se hace para algunos programas que no se enteran de los acentos).

            string acentos = "áéíóúàèìòùâêîôûäëïöüÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜ", sinAcentos = "aeiouaeiouaeiouaeiouAEIOUAEIOUAEIOUAEIOU", result = s;
            int position = -1;

            for (int i = 0; i < result.Length; i++)
            {
                position = acentos.IndexOf(result[i]);

                if (position != -1)
                {
                    result = result.Replace(result[i], sinAcentos[position]);
                }
            }

            return result;

            static string EscribeArrayNotas(double[] a)
        {
            int i;
            string s = "";
            if (a.Length>0)
            {
                s = "[";
                for (i = 0; i < a.Length-1; i++)
                {
                    ValorColor(a[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    s = s + a[i]+ ";";
                }

                ValorColor(a.Length - 1);
                Console.ForegroundColor = ConsoleColor.White; 
                s = s + a[i] + "]";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                s = "[]";
            }
            return s;
        }

        static void ValorColor(double n)
        {
            if (n > 0 && n <= 10)
            {
                if (n >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(n);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ERROR");
            }
        }

        static bool[] CalculaNPrimos(int n)
        {
            bool[] b = new bool[n + 1];

            for (int i = 0; i < b.Length; i++)
            {
                if (PRIMO(i))
                {
                    b[i] = true;
                }
                else
                {
                    b[i] = false;
                }
            }

            return b;
        }

        static bool PRIMO(int n)
        {
            bool v;
            int j = 0;
            int i;

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    j++;
                }
            }

            if (j == 2)
            {
                v = true;
            }
            else
            {
                v = false;
            }

            return v;
        }

            static bool Detecta5(int[] a)
        {
            bool v = false;
            int i, j = 0;

            for (i = 0; i < a.Length-1; i++)
            {
                if (a[i] == a[i+1])
                {
                    j++;
                    if (j == 4)
                    {
                        v = true;
                    }
                }
                else
                {
                    j = 0;
                }
            }

            return v;
        }

        static int[] TailArray(int[] a, int p)
        {
            int i;
            int[] b;
            if (p > a.Length || p < 0)
            {
                Console.WriteLine("ERROR");
                b = a;
            }
            else
            {
                b = new int[a.Length-p];
                for (i = 0; i < b.Length; i++)
                {
                    b[i] = a[p + i];
                }
            }
            return b;
        }

        static bool CompruebaTarjeta(int[] a)
        {
            bool res = true;
            int i, j, k;
            j = 0;
            k = 0;
            if (a.Length == 16)
            {
                for (i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        a[i] = a[i] * 2;
                    }

                    if (a[i] > 9)
                    {
                        a[i] = a[i] - 9;
                    }

                    j += k;

                    if (j % 10 != 0)
                    {
                        res = false;
                    }

                }
            }
            else
            {
                res = false;
            }

            return res;
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

        static string EscribeArrayDouble(double[] a)
        {
            int i;
            string s = "";
            if (a.Length > 0)
            {
                s = "[";
                for (i = 0; i < a.Length - 1; i++)
                {
                    s = s + a[i] + ";";
                }
                s = s + a[a.Length - 1] + "]";
            }
            else
            {
                s = "[]";
            }
            return s;
        }

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

        static void IntercambiaParImpar(int[] a)
        {
            int i, temp;
            temp = 0;
            i = 0;
            if (a.Length % 2 == 0) // si el array es par
            {
                for (i = 0; i < a.Length; i += 2) // i += 2 -> a i le + 2 cuando haga el for
                {
                    temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void Escribearray(int[] a)
        {
            int i;
            if (a.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < a.Length - 1; i++)
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
    }
}