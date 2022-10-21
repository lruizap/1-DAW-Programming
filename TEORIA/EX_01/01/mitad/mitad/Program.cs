using System;

namespace mitad
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double mitad;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            mitad = n / 2.0;

            Console.WriteLine("La mitad es " + mitad);

            //----------------------
            //      Operadores 
            //----------------------

            //suma

            int suma = 3 + 5;

            //resta

            int resta = 3 - 5;

            //multiplicación
            int multi = 3 * 5;

            //división!!!!!!!
            int division = 3 / 5;
            Console.WriteLine(division);

            double division2 = 3 / 5;
            Console.WriteLine(division2);

            double division3 = 3.0 / 5.0;
            Console.WriteLine(division3);

            double division4 = 3.5 / 5;
            Console.WriteLine(division4);

            //double base1, altura;
            //double area = (base1 * altura) / 2.0;               //para hacer la división con decimales

            // resto

            int division5 = 17 / 5;
            int resto5 = 17 % 5;

            Console.WriteLine("17 entre 5 sale a " + division5 + " y el resto " + resto5);

            int expresion = 3 + 4 * 5 / 2 - 9; 



        }
    }
}
