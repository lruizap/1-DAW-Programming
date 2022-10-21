using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ej3_Lucas_Ruiz_Zapata
{
    class PixelDrawing
    {
        List<Pixel> pixeles = new List<Pixel>();

        public PixelDrawing()
        {

        }
        public List<Pixel> Pixeles { get => pixeles; set => pixeles = value; }

        // Métodos

        public void SaveToFile(string filename)
        {
            FileStream fs = new FileStream("EscribeFicheroPixeles.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < pixeles.Count; i++)
            {
                bw.Write(pixeles[i].X);
                bw.Write(pixeles[i].Y);
            }

            fs.Close();
            bw.Close();
        }

        public void LoadFromFile(string filename)
        {
            pixeles.Clear();
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                int x = br.ReadInt32();
                int y = br.ReadInt32();
                Pixel p = new Pixel(x, y);
                pixeles.Add(p);
            }

            br.Close();
            fs.Close();
        }

        public void Draw()
        {
            for (int i = 0; i < pixeles.Count; i++)
            {
                Pixel p = new Pixel(pixeles[i].X, pixeles[i].Y);
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("█");
            }
        }

        public override string ToString()
        {
            string[,] array = new string[10, 10];
            string s="";

            for (int k = 0; k < pixeles.Count; k++)
            {
                Pixel p = new Pixel(pixeles[k].X, pixeles[k].Y);

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                    }
                }
            }
            return s;
        }
    }
}
