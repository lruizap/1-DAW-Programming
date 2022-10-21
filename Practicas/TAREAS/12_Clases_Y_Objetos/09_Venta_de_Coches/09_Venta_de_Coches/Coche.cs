using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Venta_de_Coches
{
    public class Coche
    {
        // atributos privados

        private string matricula;
        private DateTime fechaMatriculacion;
        private string marca;
        private string modelo;
        private double precio;

        public Coche(string matricula, DateTime fechaMatriculacion, string marca, string modelo, double precio)
        {
            if (IsValidMatricula(matricula) == true)
            {
                this.matricula = matricula;
            }
            else
            {
                throw new Exception("La matrícula tiene que estar compuesta por 4 números y 3 letras");
            }

            this.precio = precio;

            if (marca.Trim() == "" && modelo.Trim() == "")
            {
                throw new Exception("No puede estar vacio");
            }
            else
            {
                this.modelo = modelo;
                this.marca = marca;
            }

            if (DateTime.Now.Year - fechaMatriculacion.Year >= 1)
            {
                this.fechaMatriculacion = fechaMatriculacion;
            }
            else
            {
                throw new Exception("La fecha de matriculación debe ser como mínimo la del año anterior");
            }
        }

        public string Matricula { get => matricula; }
        public DateTime FechaMatriculacion { get => fechaMatriculacion; }
        public string Marca { get => marca; }
        public string Modelo { get => modelo; }
        public double Precio 
        { 
            get => precio; 
            set
            {
                if (value < 500)
                {
                    throw new Exception("El precio no puede ser inferior a 500€");
                }
                else
                {
                    this.precio = value;
                }
            }
        }

        public bool IsValidMatricula(string matricula)
        {
            bool checkedstring = false;
            int contadordigit = 0, contadorchar = 0;
            for (int i = 0; i < matricula.Length; i++)
            {
                if (char.IsLetter(matricula[i]))
                {
                    contadorchar++;
                }
                else
                {
                    if (char.IsDigit(matricula[i]))
                    {
                        contadordigit++;
                    }
                }
            }

            if (contadordigit != 4 || contadorchar != 3)
            {
                throw new Exception("La matricula es incorrecta");
            }
            else
            {
                checkedstring = true;
            }

            return checkedstring;
        }

        public override string ToString()
        {
            return "Ficha Coche : " +
                "\nMatrícula : " + matricula
                + "\nFecha de Matriculación : " + fechaMatriculacion.ToShortDateString()
                + "\nMarca : " + Marca
                + "\nModelo : " + Modelo + "\n"
                + "Precio : " + Precio;
        }
    }
}
