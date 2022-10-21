using System;

namespace Precio___descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, descuento, rebaja, resultado;

            Console.WriteLine("Dime el precio original");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el descuento aplicado");
            descuento = double.Parse(Console.ReadLine());

            descuento = (descuento / 100);

            rebaja = precio * descuento;

            resultado = (precio - rebaja);

            Console.WriteLine("El precio actual es de " + resultado);
            Console.WriteLine("La rebaja total es de " + rebaja);


        }
    }
}
