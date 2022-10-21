using System;

namespace _01_Carta_Y_Baraja
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 40; i++)
            //{
            //    Carta c = new Carta(i);
            //    Console.Write(i + "--> ");
            //    Console.WriteLine(c.NumeroCarta + ","
            //                        + c.PaloCarta + ","
            //                        + c.NombreNumero + ","
            //                        + c.NombrePalo + ","
            //                        + c.NombreCarta);
            //    Console.WriteLine("En el juego del Tute, la carta tiene el siguiente valor: " + c.ValorTute);
            //    Console.WriteLine("En el juego del Mus, la carta tiene el siguiente valor: " + c.ValorMus);
            //    Console.WriteLine("En el juego del 7 y media, la carta tiene el siguiente valor: " + c.Valor7ymedia);
            //    Console.WriteLine();
            //}

            //Baraja b = new Baraja(true);
            //for(int i = 0; i < b.listaCartas.Count; i++)
            //{
            //    Console.WriteLine(b.listaCartas[i].NombreCarta);
            //}

            //Baraja b = new Baraja(true);
            //for (int i = 0; i < 40; i++)
            //{
            //    Console.WriteLine(b.Robar());
            //}

            Baraja b = new Baraja(true);
            decimal puntos = 0;
            bool continuar = true;
            string opcion;

            while (puntos < 7.5m && continuar)
            {
                Carta c = b.Robar();
                Console.WriteLine("Has robado: " + c);
                puntos = puntos + c.Valor7ymedia;
                Console.WriteLine("Puntos totales: " + puntos);
                Console.WriteLine();
                if (puntos < 7.5m)
                {
                    Console.WriteLine("¿Quíeres otra?");
                    opcion = Console.ReadLine();

                    if (!opcion.ToLower().StartsWith("s"))
                    {
                        continuar = false;
                    }
                }
            }
            Console.WriteLine(puntos);
            if (puntos > 7.5m)
            {
                Console.WriteLine("Te has pasado");
            }
            else
            {
                if (puntos == 7.5m)
                {
                    Console.WriteLine("Has ganado");
                }
                else
                {
                    Console.WriteLine("Casi");
                }
            }
        }
    }
}
