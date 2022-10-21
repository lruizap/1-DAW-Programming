using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Hora
{
    class Hora
    {
        private int segundos;

        public Hora(int segundos)
        {
            this.segundos = segundos;
        }

        public Hora(int hora, int minuto, int segundo)
        {

            this.segundos = (hora * 3600) + (minuto * 60) + segundo;
        }

        public int SegundosTotales
        {
            get => segundos;
            set
            {
                if (value >= 0)
                {
                    this.segundos = value;
                }
                else
                {
                    throw new Exception("Los segundos deben estar entre 0");
                }
            }
        }

        public int Horas
        {
            get
            {
                int h;
                h = SegundosTotales / 3600;
                return h;
            }

            set
            {
                SegundosTotales = (value * 3600) + (Minutos * 60) + Segundos;
            }
        }

        public int Minutos
        {
            get
            {
                int m;
                m = SegundosTotales / 60;
                return m % 60;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    SegundosTotales = (Horas * 3600) + (value * 60) + Segundos;
                }
                else
                {
                    throw new Exception("Los minutos deben estar entre 0 y 60");
                }
            }
        }

        public int Segundos
        {
            get
            {
                int s;
                s = SegundosTotales % 60;
                return s;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    SegundosTotales = (Horas * 3600) + (Minutos * 60) + value;
                }
                else
                {
                    throw new Exception("Los segundos deben estar entre 0 y 60");
                }
            }
        }

        public void SumaHoras(int horas)
        {
            SegundosTotales = SegundosTotales + (horas * 3600);
        }

        public void SumaMinutos(int minutos)
        {
            SegundosTotales = SegundosTotales + (minutos * 60);
        }

        public void SumaSegundos(int segundos)
        {
            SegundosTotales = SegundosTotales + segundos;
        }

        public static Hora operator +(Hora h, Hora h2)
        {
            Hora h3 = new Hora(h.SegundosTotales + h2.SegundosTotales);
            return h3;
        }

        public static Hora operator -(Hora h, Hora h2)
        {
            if (h.SegundosTotales > h2.SegundosTotales)
            {
                return new Hora(h.SegundosTotales - h2.SegundosTotales);
            }
            else
            {
                return new Hora(h2.SegundosTotales - h.SegundosTotales);
            }
        }

        public override string ToString()
        {
            return Horas + ":" + Minutos + ":" + Segundos;
        }
    }
}
