using System;
using System.Collections.Generic;
using System.Text;

namespace Ej3_Lucas_Ruiz_Zapata
{
    class Pixel
    {
        // Atributos

        private int x;
        private int y;

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Propiedades

        public int X 
        {
            get => x;

            set
            {
                if (value >= 0 && value <= 9)
                {
                    this.x = value;
                }
                else
                {
                    throw new Exception("La coordenada debe estar situada entre 0 y 9");
                }
            }
        }
        public int Y
        {
            get => y;

            set
            {
                if (value >= 0 && value <= 9)
                {
                    this.y = value;
                }
                else
                {
                    throw new Exception("La coordenada debe estar situada entre 0 y 9");
                }
            }
        }
    }
}
