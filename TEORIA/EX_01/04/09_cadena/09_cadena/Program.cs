using System;

namespace _09_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 7; i++)
            {
                Console.WriteLine(DiaSemanaTexto(i));
            }

        }

        /// <summary>
        /// Nos devuelve el dia de la semana que le pasemos como txto
        /// </summary>
        /// <param name="dianumero">un valor entre 1 (lunes); y 7 (domingo)</param>
        /// <returns>dia semana en texto</returns>



        static string DiaSemanaTexto(int dianumero)
        {
            string resultado;

            switch (dianumero)
            {
                case 1: resultado = "Lunes"; break;
                case 2: resultado = "Martes"; break;
                case 3: resultado = "Miercoles"; break;
                case 4: resultado = "Jueves"; break;
                case 5: resultado = "Viernes"; break;
                case 6: resultado = "Sabado"; break;
                case 7: resultado = "Domingo"; break;
                default: resultado = "ERROR"; break;

            }

            return resultado;
        }
    }
}
