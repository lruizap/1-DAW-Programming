using System;

namespace _05_Dinero_Y_Moneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Dinero d = new Dinero(45.34, TipoMoneda.EURO);
            Console.WriteLine(d.ToString());
        }
    }
}
