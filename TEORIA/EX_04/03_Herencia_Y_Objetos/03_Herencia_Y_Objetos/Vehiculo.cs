using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Herencia_Y_Objetos
{
    abstract class Vehiculo // No podemos crear objetos de esta calse porque es abstracta
    {
        private string matricula;
        protected string marca;
        protected string modelo;
        protected int kilometros;

        public Vehiculo(string matricula, string marca, string modelo) // para no escribir 2 constructores y si le añades otro valor del mismo tipo despues, no sabe cual usar
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.kilometros = 0;
        }

        public Vehiculo(string matricula, string marca, string modelo, int kilometros)
            : this(matricula, marca, modelo)
        {
            this.kilometros = kilometros;
        }

        public int Kilometros
        {
            get => kilometros;
            set
            {
                if (value >= 0)
                {
                    this.kilometros = value;
                }
                else
                {
                    throw new Exception("Los kilometros no pueden ser negativos");
                }
            }
        }


        public override string ToString()
        {
            return
            "Matrícula: " + matricula + "\n" +
            "Marca y modelo: " + marca + " " + modelo + "\n" +
            "Kilometros: " + kilometros;
        }

        public abstract void CambiaMatricula(string nuevaMatricula);
    }
}
