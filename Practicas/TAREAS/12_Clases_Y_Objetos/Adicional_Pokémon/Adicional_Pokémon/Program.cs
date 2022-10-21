using System;

namespace Adicional_Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex p = new Pokedex("pokedex.prn");
            Console.WriteLine(p.ToString());
        }
    }
}
