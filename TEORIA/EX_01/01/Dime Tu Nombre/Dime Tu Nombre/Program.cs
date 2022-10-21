using System;

namespace Dime_Tu_Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);
            string cadena = "hola";
            Console.WriteLine(cadena);
            bool logico = true;
            Console.WriteLine(logico);

            // Leer una cadena

            string nombre;

            Console.WriteLine("Dime tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola " + nombre);
            
            
            
        }
    }
}
