using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _04_interface
{
    class ejemplo : IComparable<ejemplo>
    {
        private int n1;
        private int n2;

        public ejemplo(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        public int CompareTo([AllowNull] ejemplo other)
        {
            if ((this.n1+this.n2) > (other.n1 + other.n2))
            {
                return 1;
            }
            else
            {
                if ((this.n1 + this.n2) < (other.n1 + other.n2))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return "n1: " + n1 + ", n2: " + n2 + ", suma: " + (n1 + n2);
        }
    }
}
