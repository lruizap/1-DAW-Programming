using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Pixel
    {
        private int x;
        private int y;

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => x;
            
            set
            {
                if (value >= 0 && value <= 9)
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int Y { get => y; 
        
            set
            {
                if (value >= 0 && value <= 9)
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }
    }
}
