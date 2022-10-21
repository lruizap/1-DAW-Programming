using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Alumnos_Y_Grupos
{
    class Alumno
    {
        // Atributos

        private string nombre;
        private int edad;
        private double calificacion;

        // Constructores

        /// <summary>
        /// Establecer los límites de los atributos de los alumnos
        /// </summary>
        /// <param name="n">nombre del alumno != a cadena vacía</param>
        /// <param name="ed">edad del alumno dentro del valor determinado</param>
        /// <param name="calif">calificación del alumno dentro de los valores determinados</param>

        public Alumno(string n, int ed, double calif)
        {
            Nombre = n;

            Edad = ed;

            Calificacion = calif;
        }

        // Constructores

        //public Alumno ConstructorObjetos(object obj)
        //{
        //    return obj;
        //}

        // Métodos

        public override string ToString()
        {
            return nombre + " - " + edad + " - " + calificacion;
        }

        // Propiedades

        public string Nombre 
        { 
            get { return this.nombre; } 
            
            set
            {
                if (value != "")
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("El nombre debe ser != de una cadena vacía");
                }
            }   
        }

        public int Edad
        {
            get { return this.edad; }
            
            set
            {
                if (value > 16 && value <= 100)
                {
                    this.edad = value;
                }
                else
                {
                    throw new Exception("La edad tiene que estar entre 17 y 100");
                }
            }
        }

        public double Calificacion
        {
            get { return this.calificacion; }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.calificacion = value;
                }
                else
                {
                    throw new Exception("La calificación tiene que estar entre 0 y 10");
                }
            }
        }
    }
}
