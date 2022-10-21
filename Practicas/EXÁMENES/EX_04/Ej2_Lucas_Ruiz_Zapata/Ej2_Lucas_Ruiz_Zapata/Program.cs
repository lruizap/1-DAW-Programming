using System;

namespace Ej2_Lucas_Ruiz_Zapata
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            UnidadTemperatura u;
            Console.WriteLine("Dime el valor de la temperatura");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la unidad de la temperatura (C, F, K)");
            string introduc = Console.ReadLine();
            if (introduc == "C" || introduc == "c")
            {
                u = UnidadTemperatura.Celsius;
            }
            else
            {
                if (introduc == "F" || introduc == "f")
                {
                    u = UnidadTemperatura.Farenheit;
                }
                else
                {
                    if (introduc == "K" || introduc == "k")
                    {
                        u = UnidadTemperatura.Kelvin;
                    }
                    else
                    {
                        throw new Exception("Introduce un valor válido de unidad de temperatura(F,K,C)");
                    }
                }
            }

            Temperatura t = new Temperatura(valor, u);
            Console.WriteLine(t.ToString());
            Console.WriteLine(t.ConvierteEn(UnidadTemperatura.Celsius));
            Temperatura t2 = new Temperatura(32, UnidadTemperatura.Farenheit);
            Console.WriteLine(t2.ConvierteEn(UnidadTemperatura.Kelvin));
            Temperatura t3 = new Temperatura(273, UnidadTemperatura.Kelvin);
            Temperatura t4 = new Temperatura(100, UnidadTemperatura.Celsius);
            Console.WriteLine(t2 == t3);
            Console.WriteLine(t2+t3);
            Console.WriteLine(t3-t4);
        }
    }
}
