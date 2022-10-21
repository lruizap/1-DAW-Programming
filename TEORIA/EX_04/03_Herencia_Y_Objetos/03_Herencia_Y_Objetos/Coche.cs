using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Herencia_Y_Objetos
{
    class Coche : Vehiculo
    {
        private int numeroPuertas;

        public Coche(string matricula, string marca, string modelo, int numeroPuertas) 
            : base(matricula, marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
        }

        public Coche(string matricula, string marca, string modelo, int kilometros, int numeroPuertas) 
            : base(matricula, marca, modelo, kilometros)
        {
            this.numeroPuertas = numeroPuertas;
        }

        public override void CambiaMatricula(string nuevaMatricula)
        {
            throw new NotImplementedException();
        }

        public void rompePuerta() 
        {
            if (numeroPuertas > 0)
            {
                numeroPuertas--;
            }
        }

        public override string ToString()
        {
            return
            "Matrícula: " + matricula + "\n" +
            "Marca y modelo: " + marca + " " + modelo + "\n" +
            "Kilometros: " + kilometros + "\n" +
            "Puertas: " + numeroPuertas;
        }
    }
}
