using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    abstract class Animal
    {
        protected string nombre; // la comprobacion de la propiedad que sea solo de lectura las pongo en el constructor las que sean de escritura en la propiedad
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        // Propiedades

        public string Nombre { get => nombre;}

        public DateTime FechaNacimiento { get => fechaNacimiento;}

        public double Peso 
        {
            get => peso; 
            
            set
            {
                if (value > 0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("El peso no puede ser 0 o menor a este");
                }
            }
        }

        public string Comentarios
        {
            get => comentarios;
            
            set => comentarios = value; 
        }

        // Constructor

        public Animal(string nombre, DateTime fechaNacimiento, double peso)
        {
            if (nombre.Trim() == "")
            {
                throw new Exception("No puede estar vacio");
            }
            else
            {
                this.nombre = nombre;
            }

            if (fechaNacimiento < DateTime.Now)
            {
                this.fechaNacimiento = fechaNacimiento;
            }
            else
            {
                throw new Exception("La fecha de nacimiento no puede ser mayor que ahora");
            }

            this.Peso = peso;
            this.Comentarios = "";
        }

        public abstract override string ToString();

    }
}
