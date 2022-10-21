using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Clases
{
    class EquipoPokemon
    {
        private List<pokemon> lista = new List<pokemon>();

        public void InsertaPokemon(pokemon p)
        {
            lista.Add(p);
        }

        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < lista.Count; i++)
            {
                cadena = cadena + lista[i].ToString() + "\n";
            }
            return cadena;
        }
    }
}
