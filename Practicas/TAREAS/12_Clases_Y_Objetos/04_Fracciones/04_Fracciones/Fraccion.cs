using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Fracciones
{
    class Fraccion
    {
        // Atributos

        private int numerador;
        private int denominador;

        // Constructores

        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }

        public Fraccion(int numerador)
        {
            this.numerador = numerador;
            this.denominador = 1;
        }

        public Fraccion(double numerador)
        {
            this.denominador = 1;

            while (Math.Truncate(numerador) != numerador)
            {
                numerador = numerador * 10;
                denominador = denominador * 10;
            }

            this.numerador = (int)numerador;
        }

        // Propiedades

        public int Numerador { get => numerador; set => numerador = value; }

        public int Denominador
        {
            get => denominador;

            set
            {
                if (value != 0)
                {
                    this.denominador = value;
                }
                else
                {
                    throw new Exception("No puedes poner un denominador = 0");
                }
            }

        }

        // Métodos

        private int mcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }

                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        private int mcm(int a, int b)
        {
            int mcm = 0;
            mcm = (a * b) / mcd(a, b);
            return mcm;
        }

        public void Simplificar()
        {
            int MCD = mcd(numerador, denominador);
            this.numerador = numerador / MCD;
            this.denominador = denominador / MCD;
        }

        public override string ToString()
        {
            return numerador + " / " + denominador;
        }

        // Operador Unario

        public static Fraccion operator -(Fraccion f)
        {
            return new Fraccion(-f.numerador, f.denominador);
        }

        public static Fraccion operator +(Fraccion f, Fraccion f2)
        {
            if (f.denominador == f2.denominador)
            {
                int sumnum = f.numerador + f2.numerador;
                return new Fraccion(sumnum, f.denominador);
            }
            else
            {
                int dencom = f.mcm(f.denominador, f2.denominador);

                f.numerador = (dencom / f.denominador) * f.numerador;
                f2.numerador = (dencom / f2.denominador) * f2.numerador;

                return new Fraccion((f.numerador + f2.numerador), dencom);
            }
        }

        public static Fraccion operator -(Fraccion f, Fraccion f2)
        {
            //int dencom = f.mcm(f.denominador, f2.denominador);
            //f.denominador = dencom;
            //f2.denominador = dencom;

            //f.numerador = (dencom / f.denominador) * f.numerador;
            //f2.numerador = (dencom / f2.denominador) * f2.numerador;

            //return new Fraccion(f.numerador + f2.numerador, dencom);

            return f + (-f2);
        }

        public static Fraccion operator /(Fraccion f, Fraccion f2)
        {
            return new Fraccion((f.numerador * f2.denominador), (f.denominador * f2.numerador));
        }

        public static Fraccion operator *(Fraccion f, Fraccion f2)
        {
            return new Fraccion(f.numerador * f2.numerador, f.denominador * f2.denominador);
        }

        // Operadores de comparacion

        public static bool operator ==(Fraccion f, Fraccion f2)
        {
            bool res;

            if (f.numerador * f2.denominador == f2.numerador * f.denominador)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }

        public static bool operator !=(Fraccion f, Fraccion f2)
        {
            return !(f == f2);
        }

        public static bool operator >(Fraccion f, Fraccion f2)
        {
            bool res;

            if (f.denominador * f2.numerador > f.numerador * f2.denominador)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }

        public static bool operator <(Fraccion f, Fraccion f2)
        {
            return !(f > f2 || f == f2);
        }

        public static bool operator <=(Fraccion f, Fraccion f2)
        {
            return !(f > f2);
        }

        public static bool operator >=(Fraccion f, Fraccion f2)
        {
            return (f > f2 || f == f2);
        }

        // operadores implícitos

        public static implicit operator Fraccion(int n)
        {
            Fraccion f = new Fraccion(n, 1);
            return f;
        }

        public static implicit operator Fraccion(double n)
        {
            Fraccion f = new Fraccion(n);
            return f;
        }
    }
}

