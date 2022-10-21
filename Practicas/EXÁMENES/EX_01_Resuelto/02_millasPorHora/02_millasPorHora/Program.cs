using System;

namespace _02_millasPorHora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MillasPorHoaAKilometrosPorHora(85));
            Console.WriteLine(KilometrosPorHoraAMilasPorHora(137));
        }

        static double MillasPorHoaAKilometrosPorHora(double mph)
        {
            double kph;
            kph = mph * 1.609344;

            return kph;
        }

        static double KilometrosPorHoraAMilasPorHora(double kph)
        {
            return (kph / 1.609344);
        }
    }
}
