using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Profesor_Y_Tribunal
{
    enum TipoGenero
    {
        Hombre, Mujer
    }

    class Profesor
    {
        protected string nombre;
        protected string dni;
        public TipoGenero genero;

        protected string Nombre 
        { 
            get => nombre; 
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("No puede estar vacio");
                }
                else
                {
                    this.Nombre = value;
                }
            }

        }

        protected string Dni 
        { 
            get => dni; 
            set
            {
                if (value.Length != 9)
                {
                    throw new Exception("El DNI debe estar compuesto por 9 valores");
                }
                else
                {
                    this.Dni = value;
                }
            } 
        }
        public TipoGenero Genero { get => genero; set => genero = value; }

        public Profesor(string nombre, string DNI, TipoGenero genero)
        {
            this.nombre = nombre;
            this.dni = DNI;
            this.genero = genero;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ",\tDNI : " + Dni + ",\tGenero : " + Genero;
        }   
    }
}
