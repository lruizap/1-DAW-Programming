using System;

namespace Funciones_18_resolucionCamara_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mpix;
            int x, y;
            Console.WriteLine("Dime los MegaPíxeles de la cámara");
            Mpix = double.Parse(Console.ReadLine());

            ResolucionCamara(Mpix, out x, out y);

            Console.WriteLine("La foto será de " + x + " x " + y);
        }
        
        static void ResolucionCamara(double mpix, out int x, out int y)
        {
            double pix = mpix * 1000000;
            double ratio = 4.0 / 3.0;
            double x2, y2;

            x2 = Math.Sqrt(pix * ratio);
            y2 = Math.Sqrt(pix / ratio);

            x = (int)x2;
            y = (int)y2;
        }
    }
}
