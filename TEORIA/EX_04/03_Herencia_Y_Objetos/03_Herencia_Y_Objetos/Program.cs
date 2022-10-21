using System;
using System.Collections.Generic;
using System.IO;

namespace _03_Herencia_Y_Objetos
{
    class Prueba : Stream
    {
        public override bool CanRead => throw new NotImplementedException();

        public override bool CanSeek => throw new NotImplementedException();

        public override bool CanWrite => throw new NotImplementedException();

        public override long Length => throw new NotImplementedException();

        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coche c = new Coche("5974GJG", "Fiat", "500", 200000, 3);
            Moto m = new Moto("1234LOL", "Yamaha", "RD500", false);

            c.Kilometros = c.Kilometros + 100;
            m.Kilometros = 200;

            Console.WriteLine(c);
            Console.WriteLine("".PadLeft(30, '-'));
            Console.WriteLine(m);
            Console.WriteLine("".PadLeft(30, '-'));

            List<Vehiculo> l = new List<Vehiculo>();
            l.Add(c);
            l.Add(m);

            for (int i = 0; i < l.Count; i++)
            {
                //Console.WriteLine(l[i]);
                //Console.WriteLine("".PadLeft(30,'-'));

                if (l[i].GetType() == typeof(Coche))
                {
                    ((Coche)l[i]).rompePuerta();
                    Console.WriteLine(l[i]);
                    Console.WriteLine("Puerta Rota");
                }
            }

            // abstract --> no se puede usar 
            // base 
            // protected
            // : <- extends, implements,()

            DateTime dt = new DateTime(2022, 3, 10);
            //Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToString("yy-M-dd"));
            Console.WriteLine(DateTime.Now);

        }
    }
}
