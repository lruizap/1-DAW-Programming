using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Carta_Y_Baraja
{
    class Baraja
    {
        // Atributos

        public List<Carta> listaCartas = new List<Carta>();

        // Constructores

        /// <summary>
        /// crea una baraja vacia
        /// </summary>

        public Baraja()
        {

        }

        /// <summary>
        /// crea una baraja española de 40. Si es true la desordena. Si es false, las cartas estarán ordenadas
        /// </summary>
        /// <param name="barajar"></param>

        public Baraja (bool barajar)
        {
            for (int i = 1; i <= 40; i++)
            {
                Carta c = new Carta(i);
                this.listaCartas.Add(c);
            }

            if (barajar)
            {
                Barajar();
            }
        }

        // Métodos

        /// <summary>
        /// Baraja la carta si te lo pide la funcion
        /// </summary>

        public void Barajar()
        {
            List<Carta> l2 = new List<Carta>();
            Random r = new Random();
            int pos;

            while (listaCartas.Count > 0)
            {
                pos = r.Next(listaCartas.Count);
                l2.Add(listaCartas[pos]);
                listaCartas.RemoveAt(pos);
            }
            listaCartas.AddRange(l2);
        }

        /// <summary>
        /// Nos devuelve la primera carta de la baraja y la quita de la misma
        /// </summary>
        /// <returns>Carta[0]</returns>

        public Carta Robar()
        {
            if (listaCartas.Count > 0)
            {
                Carta c = listaCartas[0];
                listaCartas.RemoveAt(0);
                return c;
            }
            else
            {
                throw new Exception("No quedan cartas");
            }
        }

        /// <summary>
        /// Corta la baraja, pasando cartas del principio al final
        /// </summary>
        /// <param name="numero">numero de cartas que pasamos al final</param>

        public void Cortar(int numero)
        {
            if (numero < 1 || numero > listaCartas.Count - 1)
            {
                for (int i = 0; i < numero; i++)
                {
                    listaCartas.Add(listaCartas[0]);
                    listaCartas.RemoveAt(0);
                }
            }
            else
            {
                throw new Exception("Hay que cortar al menos una carta o dejar al menos una carta");
            }
        }

        public void InsertaCartasAlPrincipio(Carta c)
        {
            listaCartas.Insert(0, c);
        }

        /// <summary>
        /// Inserta una carta al principio de la baraja
        /// </summary>
        /// <param name="id">El id es el número identificativo de la carta que le pasaremos a la función</param>

        public void InsertaCartaAlPrincipio(int id)
        {
            listaCartas.Insert(0, new Carta(id));
        }

        public void InsertaCartaAlFinal(Carta c)
        {
            listaCartas.Add(c);
        }

        public void InsertaCartasAlFinal(int id)
        {
            listaCartas.Add(new Carta(id));
        }

        // Propiedades 

        public int NumeroCarta
        {
            get
            {
                return listaCartas.Count;
            }
        }

        public bool Vacia
        {
            get
            {
                return (listaCartas.Count == 0);
            }
        }
    }
}
