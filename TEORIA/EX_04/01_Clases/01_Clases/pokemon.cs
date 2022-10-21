using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Clases
{
    enum TipoPokemon
    {
        //Variable con ciertos valores

        Fuego, Agua, Planta, Fantasma, Bicho, Normal
    }

    enum SexoPokemon
    {
        macho, hembra, desconocido
    }

    class pokemon
    {
        // Atributos

        private int id;
        private string nombre;
        private int hpMax;
        private int hpActual;
        private int nivel;
        private TipoPokemon tipo;
        private SexoPokemon sexo;

        // Constructor

        public pokemon(int id, string nombre, SexoPokemon sexo ,TipoPokemon tipo, int hpMax, int hpActual, int nivel)
        {
            if (id >= 1 && id <= 151)
            {
                this.id = id;
            }
            else
            {
                throw new Exception("El ID tiene que estar entre 1 y 151");
            }

            Nombre = nombre;
            this.tipo = tipo;
            this.sexo = sexo;
            HpMax = hpMax;
            HpActual = hpActual;
            Nivel = nivel;

            //if (nombre.Length > 0)
            //{
            //    this.nombre = nombre;
            //}
            //else
            //{
            //    throw new Exception("El pokemon tiene que tener nombre");
            //}

            //if (hpMax > 0)
            //{
            //    this.hpMax = hpMax;
            //}
            //else
            //{
            //    throw new Exception("El pokemon tiene que tener vida positiva");
            //}

            //if (hpActual >= 0 && hpActual <= hpMax)
            //{
            //    this.hpActual = hpActual;
            //}
            //else
            //{
            //    throw new Exception("La vida actual no puede ser negativa ni mayor que la máxima");
            //}

            //if (nivel > 0 && nivel <= 100)
            //{
            //    this.nivel = nivel;
            //}
            //else
            //{
            //    throw new Exception("El nivel actual no puede ser negativo ni mayor que el máximo");
            //}
        }

        // Métodos

        public bool Desmayado
        {
            get
            {
                if (hpActual == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int GetHPActual()
        {
            return this.hpActual;
        }

        public void SetHPActual(int nuevovalor)
        {
            if (nuevovalor >= 0 && nuevovalor <= hpMax)
            {
                this.hpActual = nuevovalor;
            }
            else
            {
                throw new Exception("La vida actual no puede ser negativa ni mayor que la máxima");
            }
        }

        public void BeberPocion()
        {
            if (hpActual + 20 <= hpMax)
            {
                hpActual = hpActual + 20;
            }
            else
            {
                hpActual = hpMax;
            }
        }

        public override string ToString()
        {
            string cadena = "Pokemon: " + nombre + "(id " + id + ") Tipo: " + tipo + " Sexo: " + sexo + " level: " + nivel + " hp: " + hpActual + "/" + hpMax;

            if (Desmayado)
            {
                cadena = cadena + " x_x";
            }
            else
            {
                cadena = cadena + "";
            }
             
            return cadena;
        }

        // Propiedad

        public int HpActual
        {
            get
            {
                return this.hpActual;
            }

            set
            {
                if (value >= 0 && value <= hpMax)
                {
                    this.hpActual = value;
                }
                else
                {
                    throw new Exception("La vida actual no puede ser negativa ni mayor que la máxima");
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                if (value.Length > 0)
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("El pokemon tiene que tener nombre");
                }
            }
        }

        public int HpMax
        { 
            get
            {
                return this.hpMax;
            }
            
            set
            {
                if (value > 0)
                {
                    this.hpMax = value;
                }
                else
                {
                    throw new Exception("El pokemon tiene que tener vida positiva");
                }
            }
        }

        public int Nivel
        { 
            get
            {
                return this.nivel;
            }
            
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.nivel = value;
                }
                else
                {
                    throw new Exception("El nivel actual no puede ser negativo ni mayor que el máximo");
                }
            }
        }

        public TipoPokemon Tipo
        {
            get => tipo;

            set => tipo = value;
        }

        internal SexoPokemon Sexo { get => sexo; set => sexo = value; }
    }
}
