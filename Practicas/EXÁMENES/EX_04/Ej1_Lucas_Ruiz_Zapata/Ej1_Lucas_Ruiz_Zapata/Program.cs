using System;

namespace Ej1_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            ColeccionOnline C = new ColeccionOnline();
            TipoPlataforma tp = TipoPlataforma.Steam;
            TipoPlataforma tp2 = TipoPlataforma.Epic;
            C.ImprimeLista(tp);
            C.ImprimeLista(tp2);
        }
    }
}
