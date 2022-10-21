using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_Lucas_Ruiz_Zapata
{
    public class SmartArray
    {
        private int[] array;

        public SmartArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public override string ToString()
        {
            SmartArray a = new SmartArray(array.Length);
            int i;
            string s2 = "", s, s3;
            if (array.Length > 0)
            {
                s = "[";
                for (i = 0; i < array.Length - 1; i++)
                {
                    s2 += (array[i] + ", ");
                }
                s3 = array[array.Length - 1] + "]";

                return s + s2 + s3;
            }
            else
            {
                return "[]";
            }
        }

        public bool Contains(int value)
        {
            int i;
            bool v = false;

            for (i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    v = true;
                }
            }

            return v;
        }

        public int IndexOf(int value)
        {
            int i, res = -1;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    res = array[i] - 1;
                }
            }

            return res;
        }

        public void Sort()
        {
            int temp; 

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] >= array[i+1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }

        public void Reverse()
        {
            int i, cont, temp;
            temp = 0;
            cont = array.Length - 1;

            for (i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[cont];
                array[cont] = temp;
                cont--;

            }
        }
    
        public void Shuffle()
        {
            Random r = new Random();
            int position, temp;

            for (int i = 0; i < array.Length; i++)
            {
                position = r.Next(0, array.Length);

                temp = array[i];

                array[i] = array[position];
                array[position] = temp;
            }
        }

        public static bool operator !=(SmartArray d1, SmartArray d2)
        {
            bool v = false;

            if (d1.Length == d2.Length)
            {
                for (int i = 0; i < d1.Length; i++)
                {
                    for (int j = 0; j < d2.Length; j++)
                    {
                        if (d1[i] == d2[j])
                        {
                            v = true;
                        }
                    }
                }
            }

            return v;
        }

        public static bool operator ==(SmartArray d1, SmartArray d2)
        {
            return !(d1 != d2);
        }
    }
}

