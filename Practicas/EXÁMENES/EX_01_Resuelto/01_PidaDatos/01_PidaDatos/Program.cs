using System;

namespace _01_PidaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            double nota1, nota2, media;

            Console.WriteLine("Dime el nombre del alumno");
            nombre = Console.ReadLine();

            Console.WriteLine("Dime la edad del alumno");
            edad = int.Parse(Console.ReadLine());

            while (edad < 17 || edad > 100)
            {
                Console.WriteLine("La edad tiene que estar entre 17 y 100. Escríela de nuevo");
            }

            Console.WriteLine("Dime la nota del primer exámen");
            nota1 = double.Parse(Console.ReadLine());

            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("La nota debe estar entre 0 y 10");
            }

            Console.WriteLine("Dime la nota del segundo exámen");
            nota2 = double.Parse(Console.ReadLine());

            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("La nota debe estar entre 0 y 10");
            }

            media = (nota1 + nota2) / 2;

            Console.WriteLine(nombre + " tiene " + edad + " años");
            Console.WriteLine("ha sacado un " + nota1 + " y un " + nota2);
            Console.WriteLine("La media le sale " + media);
        }
    }
}
