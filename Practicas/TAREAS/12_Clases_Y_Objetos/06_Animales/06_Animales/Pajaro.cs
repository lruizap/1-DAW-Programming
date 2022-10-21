using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animales
{
    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis
    }

    class Pajaro : Animal
    {
        private EspeciePajaro especie;
        private bool cantor;

        public Pajaro(string nombre, EspeciePajaro especie, DateTime fechaNacimiento, double peso, bool cantor) : base(nombre, fechaNacimiento, peso)
        {
            this.Especie = especie;
            this.Cantor = cantor;
        }

        // Propiedades

        public bool Cantor { get => cantor; set => cantor = value; }

        internal EspeciePajaro Especie { get => especie; set => especie = value; }

        public override string ToString()
        {
            return "Ficha Perro : " +
                "\nNombre : " + Nombre
                + "\nRaza : " + Especie
                + "\nFecha de Nacimiento : " + FechaNacimiento
                + "\nPeso : " + Peso
                + "\nMicrochip : " + Cantor + "\n"
                + "Comentarios : " + Comentarios;
        }
    }
}
