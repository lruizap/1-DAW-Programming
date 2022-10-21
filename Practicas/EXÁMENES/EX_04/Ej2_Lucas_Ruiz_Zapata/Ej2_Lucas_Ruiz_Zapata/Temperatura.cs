using System;
using System.Collections.Generic;
using System.Text;

namespace Ej2_Lucas_Ruiz_Zapata
{
    enum UnidadTemperatura
    {
        Celsius, Farenheit, Kelvin
    }

    class Temperatura
    {
        // Atributos

        private double valor;
        private UnidadTemperatura unidad;

        // Constructor
        
        public Temperatura(double valor, UnidadTemperatura unidad)
        {
            this.valor = valor;
            this.unidad = unidad;
        }

        // Propiedades

        public double Valor { get => valor; set => valor = value; }
        public UnidadTemperatura Unidad { get => unidad;}

        // Métodos

        public override string ToString()
        {
            string sim = "";
            if (unidad == UnidadTemperatura.Celsius)
            {
                sim = "ºC";
            }
            else
            {
                if (unidad == UnidadTemperatura.Farenheit)
                {
                    sim = "ºF";
                }
                else
                {
                    if (unidad == UnidadTemperatura.Kelvin)
                    {
                        sim = "K";
                    }
                }
            }

            string result = valor + " " + sim;

            return result;
        }

        public Temperatura ConvierteEn(UnidadTemperatura unidad2)
        {
            Temperatura t = new Temperatura(Valor, Unidad);

            if (t.Unidad == UnidadTemperatura.Celsius && unidad2 == UnidadTemperatura.Farenheit)
            {
                t.Valor = (t.Valor *(9.0 / 5.0)) + 32;
            }

            if (t.Unidad == UnidadTemperatura.Kelvin && unidad2 == UnidadTemperatura.Farenheit)
            {
                t.Valor = ((t.Valor - 273) * (9.0 / 5.0)) + 32;
            }

            if (t.Unidad == UnidadTemperatura.Farenheit && unidad2 == UnidadTemperatura.Celsius)
            {
                t.Valor = (5.0 / 9.0 * (t.Valor - 32));
            }

            if (t.Unidad == UnidadTemperatura.Farenheit && unidad2 == UnidadTemperatura.Kelvin)
            {
                t.Valor = (5.0 / 9.0 * (t.Valor - 32) + 273);
            }

            if (t.unidad == UnidadTemperatura.Celsius && unidad2 == UnidadTemperatura.Kelvin)
            {
                t.Valor = (t.Valor + 273);
            }

            if (t.unidad == UnidadTemperatura.Kelvin && unidad2 == UnidadTemperatura.Celsius)
            {
                t.Valor = (t.Valor - 273);
            }

            if (t.unidad == unidad2)
            {
                t.Valor = t.Valor + 0;
            }

            Temperatura t2 = new Temperatura(t.Valor, unidad2);
            return t2;
        }

        // Operadores 

        public static Temperatura operator +(Temperatura d1, Temperatura d2)
        {
            if (d1.Unidad == d2.Unidad)
            {
                return new Temperatura(d1.Valor + d2.Valor, d1.Unidad);
            }
            else
            {
                d2.ConvierteEn(d1.Unidad);

                return new Temperatura(d1.Valor+ d2.Valor, d1.Unidad);
            }
        }

        public static Temperatura operator -(Temperatura d1, Temperatura d2)
        {
            double result;

            if (d1.Unidad == d2.Unidad)
            {
                result = d1.Valor - d2.Valor;
            }
            else
            {
                d2.ConvierteEn(d1.Unidad);
                result = d1.Valor - d2.Valor;
            }

            Temperatura d3 = new Temperatura(result, d1.Unidad);
            return d3;

        }

        public static Temperatura operator -(Temperatura d1)
        {
            return new Temperatura(-(d1.Valor), d1.Unidad);
        }

        public static double operator *(Temperatura d1, double d2)
        {
            double result;

            result = d1.Valor * d2;

            return result;
        }

        public static double operator *(double d2, Temperatura d1)
        {
            double result;

            result = d2 * d1.Valor;

            return result;
        }

        public static double operator /(Temperatura d1, double d2)
        {
            double result;

            result = d1.Valor / d2;

            return result;
        }

        public static bool operator ==(Temperatura d1, Temperatura d2)
        {
            bool result = false;

            if (d1.Unidad == d2.Unidad)
            {
                if (d1.Valor == d2.Valor)
                {
                    result = true;
                }
            }
            else
            {
                d2.ConvierteEn(d1.Unidad);
                if (d1.Valor == d2.Valor)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool operator !=(Temperatura d1, Temperatura d2)
        {
            return !(d1 == d2);
        }

        public static bool operator >(Temperatura d1, Temperatura d2)
        {
            bool result;

            if (d1.Unidad == d2.Unidad)
            {
                if (d1.Valor > d2.Valor)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                d2.ConvierteEn(d1.Unidad);
                if (d1.Valor > d2.Valor)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool operator <=(Temperatura d1, Temperatura d2)
        {
            return !(d1 > d2);
        }

        public static bool operator <(Temperatura d1, Temperatura d2)
        {
            return !(d1 > d2) && !(d1 == d2);
        }

        public static bool operator >=(Temperatura d1, Temperatura d2)
        {
            return !(d1 < d2);
        }
    }
}

