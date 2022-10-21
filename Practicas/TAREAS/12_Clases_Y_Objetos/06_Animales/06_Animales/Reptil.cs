using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeComodo
    }

    class Reptil : Animal
    {
        private EspecieReptil especie;
        private bool venenoso;

        public Reptil(string nombre, EspecieReptil especie, DateTime fechaNacimiento, double peso, bool venenoso) : base(nombre, fechaNacimiento, peso)
        {
            this.Especie = especie;
            this.Venenoso = venenoso;
        }

        // Propiedades

        public bool Venenoso { get => venenoso; set => venenoso = value; }

        internal EspecieReptil Especie { get => especie; set => especie = value; }

        public override string ToString()
        {
            return "Ficha Perro : " +
                "\nNombre : " + Nombre
                + "\nRaza : " + Especie
                + "\nFecha de Nacimiento : " + FechaNacimiento
                + "\nPeso : " + Peso
                + "\nMicrochip : " + Venenoso + "\n"
                + "Comentarios : " + Comentarios;
        }
    }
}
