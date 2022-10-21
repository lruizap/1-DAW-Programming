using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    enum RazaPerro 
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernardo
    }

    class Perro : Animal
    {
        private RazaPerro raza;
        private string microchip;

        // Constructor

        public Perro(string nombre, RazaPerro raza, DateTime fechaNacimiento, double peso, string microship) : base(nombre, fechaNacimiento, peso)
        {
            this.Raza = raza;
            this.Microchip = microship;
        }

        // Propiedades
        public string Microchip { get => microchip; set => microchip = value; }

        internal RazaPerro Raza { get => raza; set => raza = value; }

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
