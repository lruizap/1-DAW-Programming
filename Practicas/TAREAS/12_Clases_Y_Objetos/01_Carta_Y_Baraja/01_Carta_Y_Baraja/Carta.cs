using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Carta_Y_Baraja
{
    enum Palo
    {
        Oros, Copas, Espadas, Bastos
    }

    class Carta
    {
        // Atributos

        private int numero;
        private Palo palo;

        // Constructores 

        /// <summary>
        /// Crea una carta a partir del número y del palo
        /// </summary>
        /// <param name="numero">Un valor del 1 al 7 o del 10 al 12, siempre dentro de este rango</param>
        /// <param name="palo">Un valor que puede ser oros,copas,espadas,bastos</param>

        public Carta(int numero, Palo palo)
        {
            if (numero >= 1 && numero <= 12 && numero != 8 && numero != 9)
            {
                this.numero = numero;
            }
            else
            {
                throw new Exception("El número tiene que estar dentro de los valores");
            }

            this.palo = palo;
        }

        /// <summary>
        /// Crea una carta a partir de un ID. El ID comienza en el as de oros para el id 1 y termina en el rey de bastos para el valor 40
        /// </summary>
        /// <param name="id">Un valor entre 1 y 40</param>

        public Carta(int id)
        {
            // this.palo = (Palo)((id-1)/10);

            // rhis.numero = ((id-1) % 10)+1;

            //if (this.numero > 7)
            //{
            //    this.numero = this.numero + 2;
            //}

            int temp = 0;
            if (id >= 1 && id <= 40)
            {
                if (id > 0 && id < 11)
                {
                    if (id < 8)
                    {
                        numero = id;
                    }
                    else
                    {
                        temp = temp + id;
                        numero = temp + 2;
                    }
                    this.palo = Palo.Oros;
                }
                else
                {
                    if (id >= 11 && id < 21)
                    {
                        if (id < 18)
                        {
                            numero = id - 10;
                        }
                        else
                        {
                            temp = temp + id;
                            numero = (temp - 10) + 2;
                        }
                        this.palo = Palo.Copas;
                    }
                    else
                    {
                        if (id >= 21 && id < 31)
                        {
                            if (id < 28)
                            {
                                numero = id - 20;
                            }
                            else
                            {
                                temp = temp + id;
                                numero = (temp - 20) + 2;
                            }
                            this.palo = Palo.Espadas;
                        }
                        else
                        {
                            if (id < 38)
                            {
                                numero = id - 30;
                            }
                            else
                            {
                                temp = temp + id;
                                numero = (temp - 30) + 2;
                            }
                            this.palo = Palo.Bastos;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("El ID tiene que estar dentro de 1 y 40");
            }
        }

        // Propiedades

        /// <summary>
        /// devuelve un int con el número de la carta
        /// </summary>
        
        public int NumeroCarta
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Devuelve un enum de tipo Palo con el palo de la carta
        /// </summary>

        public Palo PaloCarta
        {
            get
            {
                return this.palo;
            }
        }

        /// <summary>
        /// Devuelve el nombre de la carta según el número
        /// </summary>

        public string NombreNumero
        {
            get
            {
                //string[] nombres = { "", "as", "dos", "tres", "cuatro", "cinco", "seis", "siete", "", "", "sota", "caballo", "rey" };
                //return nombres[this.numero];
                string cadena = "";
                switch (numero)
                {
                    case 1: cadena = "as"; break;
                    case 2: cadena = "dos"; break;
                    case 3: cadena = "tres"; break;
                    case 4: cadena = "cuatro"; break;
                    case 5: cadena = "cinco"; break;
                    case 6: cadena = "seis"; break;
                    case 7: cadena = "siete"; break;
                    case 10: cadena = "sota"; break;
                    case 11: cadena = "caballo"; break;
                    case 12: cadena = "rey"; break;
                    default: cadena = "";break;
                }
                return cadena;
            }
        }

        /// <summary>
        /// devuelve el nombre del palo según el palo de la carta
        /// </summary>

        public string NombrePalo
        {
            get
            {
                switch (palo)
                {
                    case Palo.Oros: return "Oros";
                    case Palo.Copas: return "Copas";
                    case Palo.Espadas: return "Espadas";
                    case Palo.Bastos: return "Bastos";
                    default: return "";
                }
            }
        }

        /// <summary>
        /// Devuelve el nombre de la carta juntando el numero y el palo
        /// </summary>

        public string NombreCarta
        {
            get 
            {
                return NombreNumero + " de " + NombrePalo;
            }
        }

        /// <summary>
        /// devuelve un int con los valores del TUTE
        /// </summary>

        public int ValorTute
        {
            get
            {
                switch (numero)
                {
                    case 1: return 11;
                    case 3: return 10;
                    case 10: return 2;
                    case 11: return 3;
                    case 12: return 4;
                    default: return 0;
                }
            }
        }

        /// <summary>
        /// devuelve un int con los valores del MUS
        /// </summary>

        public int ValorMus
        {
            get
            {
                switch (numero)
                {
                    case 2: return 1;
                    case 3: return 10;
                    case 11: return 10;
                    case 12: return 10;
                    default: return numero;
                }
            }
        }

        /// <summary>
        /// devuelve un decimal con los valores de la 7ymedia
        /// </summary>

        public decimal Valor7ymedia
        {
            get
            {
                switch (numero)
                {
                    case 10: return 0.5m;
                    case 11: return 0.5m;
                    case 12: return 0.5m;
                    default: return numero;
                }
            }
        }

        // Métodos

        public override string ToString()
        {
            return this.NombreCarta;
        }
    }
}