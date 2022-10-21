using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _3
{
    class PixelDrawing
    {
        private List<Pixel> pixels = new List<Pixel>();

        public void LoadFromFile(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int x, y;
            pixels.Clear();

            while (fs.Position < fs.Length)
            {
                x = br.ReadInt32();
                y = br.ReadInt32();
                pixels.Add(new Pixel(x, y));
            }

            br.Close();
            fs.Close();
        }

        public void SaveToFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < pixels.Count; i++)
            {
                bw.Write(pixels[i].X);
                bw.Write(pixels[i].Y);
            }

            bw.Close();
            fs.Close();
        }

        public void Draw()
        {
            for (int i = 0; i < pixels.Count; i++)
            {
                Console.SetCursorPosition(pixels[i].X, pixels[i].Y);
                Console.WriteLine("▋");
            }
        }

        public override string ToString()
        {
            int[,] array = new int[10, 10];
            string s = "";

            for (int i = 0; i < pixels.Count; i++)
            {
                array[pixels[i].X, pixels[i].Y] = 1;
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (array[x,y] == 1)
                    {
                        s = s + "▋";
                    }
                    else
                    {
                        s = s + "\n";
                    }
                }
            }

            return s;
        }
    }
}
