using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adicional_Pokémon
{
    class Pokedex
    {
        private List<Pokemon> listaPokemon = new List<Pokemon>();

        public Pokedex(string nombreFichero)
        {
            LeeFichero(nombreFichero);
            // OrdenaNombre();
            // OrdenaAtaque();
            OrdenaTipo();
        }
        public void LeeFichero(string f)
        {
            listaPokemon.Clear();
            StreamReader sr = new StreamReader(f);
            string l1 = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] trozo = linea.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = trozo[1];
                int hp = int.Parse(trozo[2]);
                int att = int.Parse(trozo[3]);
                int def = int.Parse(trozo[4]);
                int speed = int.Parse(trozo[5]);
                int spat = int.Parse(trozo[6]);
                int spdef = int.Parse(trozo[7]);
                PokemonType t1 = (PokemonType) Enum.Parse(typeof(PokemonType), trozo[8]);
                if (trozo.Length == 9)
                {
                    Pokemon p = new Pokemon(name, hp, att, def, speed, spat, spdef, t1);
                    listaPokemon.Add(p);
                }
                else
                {
                    PokemonType t2 = (PokemonType)Enum.Parse(typeof(PokemonType), trozo[9]);
                    Pokemon p = new Pokemon(name, hp, att, def, speed, spat, spdef, t1, t2);
                    listaPokemon.Add(p);
                }
            }
            sr.Close();
        }

        #region OrdenaNombre

        public void OrdenaNombre()
        {
            Pokemon min;
            List<Pokemon> l2 = new List<Pokemon>();
            Pokemon[] c = listaPokemon.ToArray();
            while (listaPokemon.Count > 0)
            {
                min = Minimo(listaPokemon);
                l2.Add(min);
                listaPokemon.Remove(min);
            }
            listaPokemon.AddRange(l2);
        }

        static Pokemon Minimo(List<Pokemon> l)
        {
            Pokemon min = l[0];
            int i;

            for (i = 0; i < l.Count; i++)
            {
                if (min.Name.Length > l[i].Name.Length)
                {
                    min = l[i];
                }
            }
            return min;
        }

        #endregion

        public void OrdenaAtaque()
        {
            listaPokemon.Sort();
        }

        public void OrdenaTipo()
        {
            listaPokemon.Sort(new ComparadorTipo());
        }

        public override string ToString()
        {
            string s1 = "\nNumero".PadRight(11) + "Pokémon".PadRight(20) + "HP".PadRight(6) + "Atk".PadRight(6) + "Def".PadRight(6) + "SpA".PadRight(6) + "SpD".PadRight(6) + "Spe".PadRight(6) + "Type1".PadRight(12) + "Type2".PadRight(12);
            string s2 = "\n======================================================================================================================";
            string s3 = "";
            int k = 1;
            for (int i = 0; i < listaPokemon.Count; i++)
            {
                s3 += "\n"+ k.ToString().PadRight(10) + listaPokemon[i].Name.PadRight(20) + listaPokemon[i].Hp.ToString().PadRight(6) + listaPokemon[i].Attack.ToString().PadRight(6) + listaPokemon[i].Defense.ToString().PadRight(6) + listaPokemon[i].SpAttack.ToString().PadRight(6)+ listaPokemon[i].SpDefense.ToString().PadRight(6) + listaPokemon[i].Speed.ToString().PadRight(6) + listaPokemon[i].Type1.ToString().PadRight(12) + listaPokemon[i].Type2.ToString().PadRight(12);
                k++;
            }

            return s1 + s2 + s3;
        }
    }
}
