using System;
using System.IO;

namespace _05_FicherosBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // bytes --> leerlo o escribirlo
            // int 4 bytes --> el más pequeño a la izq y el mayor a la der --> 0005 -> 5000 (little-endian)
            // double --> 8 bytes - IEE 754 
            // char --> 1-4 byte
            // string --> primero tamaño -> 1-4 bytes x letra (UTF-8)

            // escribir

            //FileStream fs = new FileStream("binario.bin", FileMode.Create);
            //BinaryWriter bw = new BinaryWriter(fs);

            //bw.Write(1);
            //bw.Write(2);
            //bw.Write(3);
            //bw.Write(4);
            //bw.Write(5);
            //bw.Write(0.1);
            //bw.Write("texto");

            //bw.Close();
            //fs.Close();

            // leer

            FileStream fs = new FileStream("binario.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            //int n1 = br.ReadInt32();
            //int n2 = br.ReadInt32();
            //int n3 = br.ReadInt32();
            //int n4 = br.ReadInt32();
            //int n5 = br.ReadInt32();

            //double d = br.ReadDouble();

            ////fs.Position = fs.Position + 4 * 5 + 8;

            //string s = br.ReadString();

            //Console.WriteLine(n1 + ", " + n2 + ", " + n3 + ", " + n4 + ", " + n5);
            //Console.WriteLine(d);
            //Console.WriteLine(s);

            int n;

            while (fs.Position < fs.Length)
            {
                n = br.ReadInt32();
                Console.WriteLine(n);
            }

            br.Close();
            fs.Close();
        }
    }
}
