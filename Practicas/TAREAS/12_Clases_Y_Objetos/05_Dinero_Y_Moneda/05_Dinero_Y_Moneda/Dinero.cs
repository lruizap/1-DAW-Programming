using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Dinero_Y_Moneda
{
    class Dinero
    {
        // Atributo Estático

        private static List<Moneda> listaMonedas = new List<Moneda>();

        // Constructor

        static Dinero()
        {
            listaMonedas.Add(new Moneda(TipoMoneda.EURO, 2, "€", 1m));
            listaMonedas.Add(new Moneda(TipoMoneda.USD, 2, "$", 1.0897257m));
            listaMonedas.Add(new Moneda(TipoMoneda.JPY, 0, "¥", 126.00941m));
        }

        // Métodos Estáticos

        private static Moneda BuscaMoneda(TipoMoneda t)
        {
            Moneda m = null;
            for (int i = 0; i < listaMonedas.Count; i++)
            {
                if (listaMonedas[i].TMoneda == t)
                {
                    m = listaMonedas[i];
                    i = listaMonedas.Count;
                }
            }

            return m;
        }


        public static void ActualizaCambio(TipoMoneda t, decimal cambio)
        {
            Moneda m = BuscaMoneda(t);
            m.CambioEuro = cambio;
        }

        // Atributos Normales

        private decimal cantidad;
        private TipoMoneda tMoneda;

        // Constructores

        public Dinero(decimal cantidad, TipoMoneda tMoneda)
        {
            this.cantidad = cantidad;
            this.tMoneda = tMoneda;
        }

        public Dinero(int cantidad, TipoMoneda tMoneda)
        {
            this.cantidad = cantidad;
            this.tMoneda = tMoneda;
        }

        public Dinero(double cantidad, TipoMoneda tMoneda)
        {
            this.cantidad = (decimal)cantidad;
            this.tMoneda = tMoneda;
        }

        // Propiedades

        public decimal Cantidad { get => cantidad; set => cantidad = value; }
        public TipoMoneda TMoneda { get => tMoneda; set => tMoneda = value; }

        // Métodos

        public override string ToString()
        {
            Moneda m = BuscaMoneda(TMoneda);
            string s = $"{Math.Round(cantidad)}{m.Simbolo}";
            return s;
        }

        public decimal ValorEn(TipoMoneda t)
        {
            Moneda m2 = BuscaMoneda(TMoneda);
            Moneda m = BuscaMoneda(t);
            decimal res, e;

            e = cantidad / m2.CambioEuro;

            res = e * m.CambioEuro;

            return res;
        }
        
        public Dinero ConvierteEn(TipoMoneda t)
        {
            Dinero d;
            decimal valor;
            valor = ValorEn(t);
            d = new Dinero(valor, t);
            return d;

        }

        public string ToString(TipoMoneda t)
        {
            return ConvierteEn(t).ToString();
        }

        // Métodos (operadores)

        public static Dinero operator +(Dinero d1, Dinero d2)
        {
            if (d1.TMoneda == d2.TMoneda)
            {
                return new Dinero(d1.cantidad + d2.cantidad, d1.TMoneda);
            }
            else
            {
                d2.ConvierteEn(d1.TMoneda);

                return new Dinero(d1.cantidad + d2.cantidad, d1.TMoneda);
            }
        }

        public static Dinero operator -(Dinero d1, Dinero d2)
        {
            decimal result;

            if (d1.TMoneda == d2.TMoneda)
            {
                result = d1.cantidad - d2.cantidad;
            }
            else
            {
                d2.ConvierteEn(d1.TMoneda);
                result = d1.cantidad - d2.cantidad;
            }

            Dinero d3 = new Dinero(result, d1.TMoneda);
            return d3;

        }

        public static Dinero operator -(Dinero d1)
        {
            return new Dinero (-(d1.cantidad), d1.TMoneda);
        }

        public static decimal operator *(Dinero d1, decimal d2)
        {
            decimal result;

            result = d1.cantidad * d2;

            return result;
        }

        public static decimal operator *(decimal d2, Dinero d1)
        {
            decimal result;

            result = d2 * d1.cantidad;

            return result;
        }

        public static decimal operator /(Dinero d1, decimal d2)
        {
            decimal result;

            result = d1.cantidad / d2;

            return result;
        }

        public static bool operator ==(Dinero d1, Dinero d2)
        {
            bool result = false;

            if (d1.TMoneda == d2.TMoneda)
            {
                if (d1.cantidad == d2.cantidad)
                {
                    result = true;
                }
            }
            else
            {
                d2.ConvierteEn(d1.TMoneda);
                if (d1.cantidad == d2.cantidad)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool operator !=(Dinero d1, Dinero d2)
        {
            return !(d1 == d2);
        }

        public static bool operator >(Dinero d1, Dinero d2)
        {
            bool result;

            if (d1.TMoneda == d2.TMoneda)
            {
                if (d1.cantidad > d2.cantidad)
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
                d2.ConvierteEn(d1.TMoneda);
                if (d1.cantidad > d2.cantidad)
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

        public static bool operator <=(Dinero d1, Dinero d2)
        {
            return !(d1 > d2);
        }

        public static bool operator <(Dinero d1, Dinero d2)
        {
            return !(d1 > d2) && !(d1 == d2);
        }

        public static bool operator >=(Dinero d1, Dinero d2)
        {
            return !(d1 < d2);
        }
    }
}
