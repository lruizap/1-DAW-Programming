using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Dinero_Y_Moneda
{
    public enum TipoMoneda
    {
        USD, EURO, JPY
    }

    class Moneda
    {
        // Atributos

        private TipoMoneda tMoneda;
        private int decimales;
        private string simbolo;
        private decimal cambioEuro;

        // Constructor

        public Moneda(TipoMoneda tMoneda, int decimales, string simbolo, decimal cambioEuro)
        {
            this.tMoneda = tMoneda;
            this.cambioEuro = cambioEuro;

            if (decimales >= 0 && decimales <= 4)
            {
                this.decimales = decimales;
            }
            else
            {
                throw new Exception("El numero de decimales tiene que estar comprendido entre 0 y 4");
            }

            if (simbolo == "")
            {
                throw new Exception("El símbolo de la moneda no puede estar vacio");
            }
            else
            {
                this.simbolo = simbolo;
            }
        }

        // Propiedades

        public decimal CambioEuro
        {
            get => cambioEuro;

            set
            {
                if (value >= 0)
                {
                    this.cambioEuro = value;
                }
                else
                {
                    throw new Exception("La valoración debe estar comprendida entre 0 y 100");
                }
            }
        }

        public string Simbolo { get => simbolo;}

        public int Decimales { get => decimales;}

        public TipoMoneda TMoneda { get => tMoneda;}
    }
}
