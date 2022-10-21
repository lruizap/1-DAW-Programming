using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class SmartArray
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
            return "[" + string.Join(",", array) + "]";
        }

        public bool Contains(int value)
        {
            return new List<int>(array).Contains(value);
        }

        public int IndexOf(int value)
        {
            return new List<int>(array).IndexOf(value);
        }

        public void Sort()
        {
            Array.Sort(array);
        }

        public void Reverse()
        {
            Array.Reverse(array);
        }

        public void Shuffle()
        {
            Random r = new Random();
            List<int> lista = new List<int>(array);
            int i = 0;
            int pos;

            for (i = 0; i < array.Length; i++)
            {
                pos = r.Next(lista.Count);
                array[i] = lista[pos];
                lista.RemoveAt(pos);
            }
        }

        public static bool operator ==(SmartArray a1, SmartArray a2)
        {
            if (a1.array.Length == a2.array.Length)
            {
                for (int i = 0; i < a1.array.Length; i++)
                {
                    if (a1.array[i] != a2.array[i])
                    {
                        return false;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(SmartArray a1, SmartArray a2)
        {
            return !(a1 == a2);
        }
    }
}
