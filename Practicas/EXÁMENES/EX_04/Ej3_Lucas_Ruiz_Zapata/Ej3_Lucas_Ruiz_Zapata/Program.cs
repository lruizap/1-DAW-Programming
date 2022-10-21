using System;

namespace Ej3_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            PixelDrawing p = new PixelDrawing();
            p.LoadFromFile("chess.bin");
            Console.WriteLine(p.ToString());
        }
    }
}
