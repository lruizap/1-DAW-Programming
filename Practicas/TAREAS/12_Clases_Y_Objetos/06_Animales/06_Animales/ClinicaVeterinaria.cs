using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    class ClinicaVeterinaria
    {
        private static List<Animal> listaAnimales = new List<Animal>();

        public ClinicaVeterinaria()
        {
        }

        public static void InsertaUnAnimal(Animal a)
        {
            listaAnimales.Add(a);
        }

        public static Animal BuscaAnimal(string t)
        {
            Animal a = null;
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == t)
                {
                    a = listaAnimales[i];
                    i = listaAnimales.Count;
                }
            }

            return a;
        }

        public static Animal ModificaComentarioAnimal(string t, string c)
        {
            Animal a = null;
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == t)
                {
                    a = listaAnimales[i];
                    c = listaAnimales[i].Comentarios;
                    i = listaAnimales.Count;
                }
            }

            return a;
        }

        public override string ToString()
        {
            return listaAnimales.ToString();
        }

    }
}
