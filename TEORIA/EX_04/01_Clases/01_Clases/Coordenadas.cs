using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Clases
{
    class Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }

        public override string ToString()
        {
            return "( " + X + ", " + Y + ") ";
        }

        // operadores 

        public static Coordenadas operator +(Coordenadas c1, Coordenadas c2)
        {
            int sumax = c1.X + c2.X;
            int sumay = c1.Y + c2.Y;

            Coordenadas c3 = new Coordenadas(sumax, sumay);

            return c3;
        }

        //public static Coordenadas operator +(Coordenadas c1, int n)
        //{
        //    int sumax = c1.X + n;
        //    int sumay = c1.y + n;
        //    return new Coordenadas(sumax, sumay);
        //}

        //public static Coordenadas operator +(int n, Coordenadas c1)
        //{
        //    return c1 + n;
        //}

        public static Coordenadas operator -(Coordenadas c1)
        {
            return new Coordenadas(-c1.X, -c1.Y);
        }

        public static bool operator ==(Coordenadas c1, Coordenadas c2)
        {
            if (c1.X == c2.X && c1.Y == c2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Coordenadas c1, Coordenadas c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator Coordenadas(int n)
        {
            return new Coordenadas(n, n);
        }
    }
}
