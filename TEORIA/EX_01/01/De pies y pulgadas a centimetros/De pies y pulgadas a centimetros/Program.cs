using System;

namespace De_pies_y_pulgadas_a_centimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            //double pie, pulgada, resultado;

            //Console.WriteLine("Altura en Pies");
            //pie = double.Parse(Console.ReadLine());

            //Console.WriteLine("Altura en Pulgadas");
            //pulgada = double.Parse(Console.ReadLine());

            //resultado = ((pie * 12) + pulgada) * 2.54;

            //Console.WriteLine("Mides " + resultado + " centimetros");


            //double d = 68.9;
            //int i = (int) Math.Round(d);    //transformar doble a entero pero antes asegurarse que no tiene decimales
            // (int) transforma double en int

            double cms, resultado;
            int entero, pies, pulgadas;

            Console.WriteLine("Dime los cm");
            cms = double.Parse(Console.ReadLine());

            resultado = cms / 2.54;
            entero = (int)Math.Round(resultado);

            pies = entero / 12;
            pulgadas = entero % 12;

            Console.WriteLine("la altura es " + pies + "' " + pulgadas + "/");

            







            






        }
    }
}
