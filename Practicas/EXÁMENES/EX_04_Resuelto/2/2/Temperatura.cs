using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public enum UnidadTemperatura { Celsius, Farenheit, Kelvin}

    class Temperatura
    {
        private double valor;
        private UnidadTemperatura unidad;

        public Temperatura(double valor, UnidadTemperatura unidad)
        {
            Valor = valor;
            this.unidad = unidad;
        }

        public UnidadTemperatura Unidad { get => unidad; }
        public double Valor { get => valor; set => valor = value; }

        public override string ToString()
        {
            string s = valor + " ";
            switch(unidad)
            {
                case UnidadTemperatura.Celsius: s = s + "ºC"; break;
                case UnidadTemperatura.Farenheit: s = s + "ºF"; break;
                case UnidadTemperatura.Kelvin: s = s + "K"; break;
            }
            return s;
        }

        public Temperatura ConvierteEn(UnidadTemperatura unidad2)
        {
            double valor2;

            if (unidad == UnidadTemperatura.Celsius && unidad2 == UnidadTemperatura.Farenheit)
            {
                valor2 = (9.0 / 5.0 * valor) + 32;
            }
            else if (unidad == UnidadTemperatura.Kelvin && unidad2 == UnidadTemperatura.Farenheit)
            {
                valor2 = (9.0 / 5.0 * (valor - 273)) + 32;
            }
            else if (unidad == UnidadTemperatura.Farenheit && unidad2 == UnidadTemperatura.Celsius)
            {
                valor2 = (5.0 / 9.0) * valor - 32;
            }
            else if (unidad == UnidadTemperatura.Celsius && unidad2 == UnidadTemperatura.Kelvin)
            {
                valor2 = valor + 273;
            }
            else if (unidad == UnidadTemperatura.Kelvin && unidad2 == UnidadTemperatura.Celsius)
            {
                valor2 = valor - 273;
            }
            else if (unidad == UnidadTemperatura.Farenheit && unidad2 == UnidadTemperatura.Kelvin)
            {
                valor2 = (5.0 / 9.0) * (valor - 32) + 273;
            }
            else
            {
                valor2 = valor;
            }

            Temperatura t2 = new Temperatura(valor2, unidad2);
            return t2;
        }

        public static bool operator ==(Temperatura t1, Temperatura t2)
        {
            if (t1.unidad == t2.unidad)
            {
                if (t1.valor == t2.valor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Temperatura t2b = t2.ConvierteEn(t1.unidad);
                if (t1.valor == t2b.valor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator !=(Temperatura t1, Temperatura t2)
        {
            return !(t1 == t2);
        }

        public static bool operator >(Temperatura t1,Temperatura t2)
        {
            return t1.valor > t2.ConvierteEn(t1.unidad).valor;
        }

        public static bool operator <(Temperatura t1, Temperatura t2)
        {
            return t1.valor < t2.ConvierteEn(t1.unidad).valor;
        }

        public static bool operator >=(Temperatura t1, Temperatura t2)
        {
            return t1.valor >= t2.ConvierteEn(t1.unidad).valor;
        }

        public static bool operator <=(Temperatura t1, Temperatura t2)
        {
            return t1.valor <= t2.ConvierteEn(t1.unidad).valor;
        }
    }
}
