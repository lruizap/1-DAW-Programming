using System;

namespace Leer_Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer enteros

            int edad;

            Console.WriteLine("¿Cuántos años tienes?");
            edad = int.Parse(Console.ReadLine());           //int.parase variable la convierte a una equivalente. "pasar numeros a letras"
            Console.WriteLine("Tienes " + edad + " años");

            // Leer Reales // Para leer 1.7 se tiene que poner con la coma : 1,7

            double dinero;

            Console.WriteLine("¿Cúanto cuesta el café?");
            dinero = double.Parse(Console.ReadLine());
            Console.WriteLine("El café vale " + dinero);

            // Leer boolean 

            bool booleano;

            Console.WriteLine("escribe un boolean");
            booleano = bool.Parse(Console.ReadLine());
            Console.WriteLine(booleano);

            // Leer caracteres 

            char letra;

            Console.WriteLine( "escribe una letra");
            letra = Console.ReadLine()[0];
            Console.WriteLine(letra);

            char letraa = 'a';
            string cadenaa = "a";
           

        }
    }
}
