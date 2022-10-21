using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    enum RazaGato
    {
        Comun, Siames, Persa, Angora, ScottishFold
    }

    class Gato : Animal
    {
        private RazaGato raza;
        private string microchip;

        public Gato(string nombre, RazaGato raza, DateTime fechaNacimiento, double peso, string microship) : base(nombre, fechaNacimiento, peso)
        {
            this.Raza = raza;
            this.Microchip = microship;
        }

        // Propiedades
        public string Microchip { get => microchip; set => microchip = value; }

        internal RazaGato Raza { get => raza; set => raza = value; }

        public override string ToString()
        {
            return "Ficha Perro : " +
                "\nNombre : " + Nombre
                + "\nRaza : " + Raza
                + "\nFecha de Nacimiento : " + FechaNacimiento
                + "\nPeso : " + Peso
                + "\nMicrochip : " + Microchip + "\n"
                + "Comentarios : " + Comentarios;
        }
    }


}
