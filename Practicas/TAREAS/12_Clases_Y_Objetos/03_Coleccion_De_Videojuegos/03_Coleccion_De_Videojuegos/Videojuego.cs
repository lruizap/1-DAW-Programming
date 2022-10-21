using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Coleccion_De_Videojuegos
{
    class Videojuego
    {
        //Atributos

        private string nombre;
        private int anno;
        private Plataforma plataforma;
        private TipoJuego tipoJuego;
        private int valoracion;

        //Propiedades

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

        public int Anno
        {
            get { return this.anno; }

            set
            {
                if (value >= 1970 && value <= 2100)
                {
                    this.anno = value;
                }
                else
                {
                    throw new Exception("El año debe estar comprendido entre 1970 y 2100");
                }
            }
        }

        public Plataforma Plataforma { get => plataforma; set => plataforma = value; }
        
        public TipoJuego TipoJuego { get => tipoJuego; set => tipoJuego = value; }

        public int Valoracion
        {
            get
            {
                return this.valoracion;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.valoracion = value;
                }
                else
                {
                    throw new Exception("La valoración debe estar comprendida entre 0 y 100");
                }
            }
        }

        //Constructor

        public Videojuego(string nombre, int anno, Plataforma plat, TipoJuego tj, int valoracion)
        {
            this.Nombre = nombre;
            this.Anno = anno;
            this.Plataforma = plat;
            this.TipoJuego = tj;
            this.Valoracion = valoracion;

        }

        //Métodos

        public override string ToString()
        {
            return Nombre + ";" + Anno + ";" + Plataforma + ";" + TipoJuego + ";" + Valoracion;
        }

    }
}
