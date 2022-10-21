using System;

namespace _05_Cadenas
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
                        Console.WriteLine("║1- NumeroEspacio                         ║");
                        Console.WriteLine("║2- NumeroVocales                         ║");
                        Console.WriteLine("║3- EsPalindromo                          ║");
                        Console.WriteLine("║4- Contiene                              ║");
                        Console.WriteLine("║5- RepiteCaracter                        ║");
                        Console.WriteLine("║6- QuitaEspacios                         ║");
                        Console.WriteLine("║7- QuitaEspaciosTrim                     ║");
                        Console.WriteLine("║8- SustituyeCaracter                     ║");
                        Console.WriteLine("║9- CuentaPalabras                        ║");
                        Console.WriteLine("║10- EsNumero                             ║");
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
                            Console.WriteLine("║1- NumeroEspacio                         ║");
                            Console.WriteLine("║2- NumeroVocales                         ║");
                            Console.WriteLine("║3- EsPalindromo                          ║");
                            Console.WriteLine("║4- Contiene                              ║");
                            Console.WriteLine("║5- RepiteCaracter                        ║");
                            Console.WriteLine("║6- QuitaEspacios                         ║");
                            Console.WriteLine("║7- QuitaEspaciosTrim                     ║");
                            Console.WriteLine("║8- SustituyeCaracter                     ║");
                            Console.WriteLine("║9- CuentaPalabras                        ║");
                            Console.WriteLine("║10- EsNumero                             ║");
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
                                    Console.WriteLine("Dime una frase o palabra cualquiera");
                                    string s;
                                    s = Console.ReadLine();
                                    Console.Write("El número de espacios en blanco de '" + s + "' es de: " + NumeroEspacios(s));
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra cualquiera");
                                    string s;
                                    s = Console.ReadLine();
                                    Console.Write("El número de vocales de '" + s + "' es de: " + NumeroVocales(s));
                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime palabra cualquiera");
                                    string s;
                                    s = Console.ReadLine();
                                    EsPalindromo(s);
                                    if (EsPalindromo(s) == true)
                                    {
                                        Console.WriteLine(true);
                                    }
                                    else
                                    {
                                        Console.WriteLine(false);
                                    }
                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime palabra cualquiera");
                                    string s;
                                    s = Console.ReadLine();
                                    char l;
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    l = char.Parse(Console.ReadLine());
                                    Contiene(s, l);
                                    if (Contiene(s,l) == true)
                                    {
                                        Console.WriteLine("Contiene el carácter");
                                    }
                                    else
                                    {
                                        Console.WriteLine("NO Contiene el carácter");
                                    }
                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    char l = char.Parse(Console.ReadLine());
                                    Console.WriteLine("Dime un número");
                                    int n = int.Parse(Console.ReadLine());
                                    Console.WriteLine(RepiteCaracter(l,n));
                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(QuitaEspacios(s));
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(">"+QuitaEspaciosTrim(s)+"<");
                                }
                                break;
                            case 8:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    char l = char.Parse(Console.ReadLine());
                                    Console.WriteLine("Dime un carácter sustituto");
                                    char l2 = char.Parse(Console.ReadLine());
                                    Console.WriteLine(SustituyeCaracter(s, l, l2));
                                }
                                break;
                            case 9:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(CuentaPalabras(s));
                                }
                                break;
                            case 10:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(EsNumero(s));
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

                        #region Menu_3

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        int ejercicio;

                        Console.Clear();
                        Console.WriteLine("╔════╗");
                        Console.WriteLine("║Menú║");
                        Console.WriteLine("╚════╝");
                        Console.WriteLine("╔═══════════════════════════════════════════╗");
                        Console.WriteLine("║ ┌───────────────────────────────────────┐ ║");
                        Console.WriteLine("║ │   Elige un ejercicio                  │ ║");
                        Console.WriteLine("║ └───────────────────────────────────────┘ ║");
                        Console.WriteLine("║11 - QuitaCaracter                         ║");
                        Console.WriteLine("║12-  QuitaAcentos                          ║");
                        Console.WriteLine("║13-  InvierteCadena                        ║");
                        Console.WriteLine("║14-  VecesCaracter                         ║");
                        Console.WriteLine("║15-  VecesPalabra                          ║");
                        Console.WriteLine("║16-  MayusculasPrimera                     ║");
                        Console.WriteLine("║17-  SustituyePalabra                      ║");
                        Console.WriteLine("║18-  InviertePalabras                      ║");
                        Console.WriteLine("║19-  MarcaSubCadena                        ║");
                        Console.WriteLine("║20-  QuitaEspaciosSobrantes                ║");
                        Console.WriteLine("║   ...                                     ║");
                        Console.WriteLine("║0- Salir                                   ║");
                        Console.WriteLine("╚═══════════════════════════════════════════╝");
                        ejercicio = int.Parse(Console.ReadLine());

                        while (ejercicio < 11 || ejercicio > 21)
                        {
                            Console.Clear();
                            Console.WriteLine("╔════╗");
                            Console.WriteLine("║Menú║");
                            Console.WriteLine("╚════╝");
                            Console.WriteLine("╔═══════════════════════════════════════════╗");
                            Console.WriteLine("║ ┌───────────────────────────────────────┐ ║");
                            Console.WriteLine("║ │   Elige un ejercicio                  │ ║");
                            Console.WriteLine("║ └───────────────────────────────────────┘ ║");
                            Console.WriteLine("║11 - QuitaCaracter                         ║");
                            Console.WriteLine("║12-  QuitaAcentos                          ║");
                            Console.WriteLine("║13-  InvierteCadena                        ║");
                            Console.WriteLine("║14-  VecesCaracter                         ║");
                            Console.WriteLine("║15-  VecesPalabra                          ║");
                            Console.WriteLine("║16-  MayusculasPrimera                     ║");
                            Console.WriteLine("║17-  SustituyePalabra                      ║");
                            Console.WriteLine("║18-  InviertePalabras                      ║");
                            Console.WriteLine("║19-  MarcaSubCadena                        ║");
                            Console.WriteLine("║20-  QuitaEspaciosSobrantes                ║");
                            Console.WriteLine("║   ...                                     ║");
                            Console.WriteLine("║0- Salir                                   ║");
                            Console.WriteLine("╚═══════════════════════════════════════════╝");
                            ejercicio = int.Parse(Console.ReadLine());
                        }

                        #endregion

                        #region Relación_2_Ejercicios

                        switch (ejercicio)
                        {
                            case 11:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    char l = char.Parse(Console.ReadLine());
                                    Console.WriteLine(QuitaCaracter(s, l));
                                }
                                break;
                            case 12:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(QuitaAcentos(s));
                                }
                                break;
                            case 13:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(InvierteCadena(s));
                                    
                                }
                                break;
                            case 14:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    char l = char.Parse(Console.ReadLine());
                                    Console.WriteLine("El carácter se repite: " + VecesCaracter(s, l) + " veces");
                                }
                                break;
                            case 15:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime un carácter cualquiera");
                                    string s2 = Console.ReadLine();
                                    Console.WriteLine("La palabra se repite: " + VecesPalabra(s, s2) + " veces");
                                    
                                }
                                break;
                            case 16:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase o palabra");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(MayusculasPrimera(s)); 
                                }
                                break;
                            case 17:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime una palabra");
                                    string pal = Console.ReadLine();
                                    Console.WriteLine("Dime la palabra sustituta");
                                    string palsus = Console.ReadLine();
                                    Console.WriteLine(SustituyePalabra(s, pal, palsus));
                                }
                                break;
                            case 18:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(InviertePalabras(s));
                                }
                                break;
                            case 19:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase");
                                    string s = Console.ReadLine();
                                    Console.WriteLine("Dime una palabra que esté dentro de la primera frase");
                                    string s2 = Console.ReadLine();
                                    Console.WriteLine(MarcaSubCadena(s, s2));
                                }
                                break;
                            case 20:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Dime una frase");
                                    string s = Console.ReadLine();
                                    Console.WriteLine(QuitaEspaciosSobrantes(s));
                                }
                                break;
                            case 21:
                                {
                                    string s = "Hola,don,pepito,pasó,usted,ya,por,casa?";
                                    Console.WriteLine(s);
                                    string s2 = ordenapalabrascomas(s);
                                    Console.WriteLine(s2);
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
                case 3:
                    {
                        #region Adicionales

                        #region Menu_4

                        #endregion

                        #region Adicionales_Ejercicios

                        #endregion

                        #endregion
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

        static string ordenapalabrascomas2(string s)
        {
            string[] palabras = s.Split(',');
            int i, j;
            string temp;
            for (i = 0; i < palabras.Length; i++)
            {
                for (j = 0; j < palabras.Length-1; j++)
                {
                    if (palabras[j].CompareTo(palabras[j+1]) > 0)
                    {
                        temp = palabras[j];
                        palabras[j] = palabras[j + 1];
                        palabras[j + 1] = temp;
                    }
                }
            }
            string resultado = string.Join(',', palabras);

            return resultado;
        }

        static string ordenapalabrascomas(string s)
        {
            string[] palabras = s.Split(',');
            Array.Sort(palabras);
            string resultado = string.Join(',', palabras);

            return resultado;
        }

        #region Funciones_02

        static string QuitaEspaciosSobrantes(string s)
        {
            int i;
            s = QuitaEspaciosTrim(s);
            for (i = 0; i < s.Length; i++)
            {
                s = s.Replace("  ", " ");
            }

            return s;
        }

        static string Quitaespaciossobrantes2(string s)
        {
            return string.Join(' ', QuitaEspaciosTrim(s).Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        static string MarcaSubCadena(string s, string s2)
        {

            //string s3 = "*" + s3.Substring(1);
            //while (s.Contains(s2))
            //{
            //    s = s.Replace(s2, s3);
            //}

            //return s.Replace(s2, s3);

            //int i;
            //for (i = 0; i < s.Length - s2.Length + 1; i++)
            //{
            //    if (s.Substring(i, s2.Length) == s2)
            //    {
            //        s = s.Substring(0, 1) + "*" + s.Substring(i + 1);
            //    }
            //}
            //return s;

            int i;
            string palabra;
            palabra = "";
            string[] array = s.Split(" ");
            for (i = 0; i < array.Length; i++)
            {
                palabra = array[i];
                if (palabra == s2)
                {
                    char letra = palabra[0];
                    palabra = "*" + palabra.Remove(0, 1);
                    array[i] = palabra;
                }
            }

            return string.Join(' ', array);
        } // 19

        static string InviertePalabras(string s)
        {
            int i;
            string temp, palabra;
            s = " " + s;
            palabra = "";
            temp = "";
            string[] array = s.Split(" ");
            for (i = 0; i < array.Length; i++)
            {
                palabra = array[i];
                palabra = InvierteCadena(palabra);
                temp = temp + palabra + " ";
            }
            temp = temp.Remove(0, 1);
            s = temp;

            return s;
        } // 18

        static string SustituyePalabra(string s, string pal, string palsus)
        {
            int i;
            string s2 = "";
            string[] array = s.Split(" ");
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == pal)
                {
                    s = s.Replace(pal, palsus);
                }
            }

            s2 = s;
            return s2;
        } // 17

        #region Mayúsculas y 16

        static string MayusculasPrimera(string s)
        {
            int i;
            string palabra;
            string[] array = s.Split(" ");
            string s2 = "";
            for (i = 0; i < array.Length; i++)
            {
                palabra = array[i];
                char letra = palabra.ToUpper()[0];
                palabra = palabra.Remove(0, 1);
                palabra = palabra.Insert(0, letra.ToString());
                s2 = s2 + palabra + " ";

                // split(" ");
                // if(palabra[i].Length > 0)
                //{
                //s = palabra[i];
                //s = chat.ToUpper(s[0]) + s.Substring(1);
                //palabra[i] = s;
                //}
                // join(" ", palabra);
            }
            return s2;
        } // 16

        static string Mayusculas(string s)
        {
            if (s.Length > 0)
            {
                s = char.ToUpper(s[0]) + s.Substring(1);
            }
            return s;
        } 
        // MAYUSCULAS 

        //static string MayusculasPrimera(string s)
        //{
        //    int i;
        //    char letra;
        //    s = ' ' + s;
        //    for (i = 0; i < s.Length - 1; i++)
        //    {
        //        if (s[i] != ' ' && s[i - 1] == ' ')
        //        {
        //            letra = char.ToUpper(s[i]);
        //            s = s.Remove(i, 1);
        //            s = s.Insert(i, letra.ToString());
        //        }
        //    }
        //    s = s.Remove(0, 1);
        //    return s;
        //}

        #endregion

        static int VecesPalabra(string s, string palabra)
        {
            int i, j;
            string[] array = s.Split(" ");
            j = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == palabra )
                {
                    j++;
                }
            }

            return j;
        } // 15
        
        static int VecesCaracter(string s, char l)
        {
            int i, j;
            j = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == l)
                {
                    j++;
                }
            }

            return j;
        } // 14

        static string InvierteCadena(string s)
        {
            string temp = "";
            for (int j = s.Length -1; j >= 0; j--)
            {
                temp = temp + s[j];
            }

            s = temp;

            return s;
        } // 13

        static string QuitaAcentos(string s)
        {
            int i, pos;
            string sac, ssac;
            sac = "áÁéÉíÍóÓúÚ";
            ssac = "aAeEiIoOuU";
            for (i = 0; i < s.Length; i++)
            {
                if (sac.Contains(s[i]))
                {
                    pos = sac.IndexOf(s[i]);
                    s = s.Replace(s[i], ssac[pos]);
                    //s = s.Remove(i, 1);
                    //s = s.Insert(i, ssac[pos].ToString());
                }
            }

            return s;
        } // 12

        static string QuitaCaracter(string s, char l)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == l)
                {
                    s = s.Remove(i,1);
                    i--;
                }
            }

            return s;
        } // 11

        #endregion

        #region Funciones_01

        static bool EsNumero(string s)
        {
            int j;
            j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    j++;
                }

            }

            if (j == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // 10

        static int CuentaPalabras(string s)
        {
            int i, j;
            j = 0;
            s = " " + s;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s[i+1] != ' ')
                {
                    j++;
                }
            }

            return j;
        } // 9

        static string SustituyeCaracter(string s, char l, char l2)
        {
            int i;
            string s2 = s;
            for (i = 0; i < s2.Length; i++)
            {
                if (s2[i] == l)
                {
                    s2 = s2.Remove(i,1);
                    s2 = s2.Insert(i, l2.ToString());

                    //s2 = s2.Substring(0, i) + l2 + s2.Substring(i + 1);
                }
            }

            return s2;

            // return s.replace(l,l2);
        } // 8

        static string SustituyeCaracter2(string s, char l, char l2)
        {
            int i;
            string s2 = "";
            //StringBuilder sb = new StringBuilder();
            for (i = 0; i < s2.Length; i++)
            {
                if (s2[i] == l)
                {
                    //sb.Append(c2);
                    s2 = s2 + l2;
                }
                else
                {
                    //sb.Append(s[i]);
                    s2 = s2 + s[i];
                }
            }

            return s2;

        } // 8 prueba

        static string QuitaEspaciosTrim(string s)
        {
            #region for
            //for (i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        s = s.Remove(i, 1);
            //        i--;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            //for (i = s.Length-1; i >= 0; i--)
            //{
            //    if (s[i] == ' ')
            //    {
            //        s = s.Remove(i, 1);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region while eficiente

            //int i = 0;
            //int j = s.Length - 1;

            //while (i < s.Length && s[i] == ' ')
            //{
            //    i++;
            //}

            //while (j >= 0 && s[j] == ' ')
            //{
            //    j--;
            //}

            //return s.Substring(i, j - i + 1);

            #endregion

            while (s[0] == ' ')
            {
                s = s.Remove(0, 1);
            }

            while (s[s.Length-1] == ' ')
            {
                s = s.Remove(s.Length-1, 1);
            }

            return s;
        } // 7

        static string QuitaEspacios(string s)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }
            return s;
        } // 6

        static string RepiteCaracter(char l, int n)
        {
            int i;
            string s = "";
            for (i = 0; i < n; i++)
            {
                s = s + l;
            }
            return s;
        } // 5

        static bool Contiene(string s, char l)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == l)
                {
                    return true;
                }
            }

            return false;
        } // 4

        static bool EsPalindromo(string s)
        {
            int j, i;
            bool v;
            v = false;
            for (i = 0, j = s.Length-1; i < j; i++, j--)
            {
                if (s[i] == s[j])
                {
                    v = true;
                }
            }

            return v;
        } // 3

        static int NumeroVocales(string s)
        {
            int esp, i;
            esp = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'o' || s[i] == 'i' || s[i] == 'u')
                {
                    esp++;
                }
            }

            return esp;
        } // 2

        static int NumeroEspacios(string s)
        {
            int esp, i;
            esp = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    esp++;
                }
            }

            return esp;
        } // 1

        #endregion

        //Comparar 2 cadenas

        //string s1 = "patata";
        //string s2 = "Cebollla";
        //if (s1.compareto(s2) < 0)

    }
}
