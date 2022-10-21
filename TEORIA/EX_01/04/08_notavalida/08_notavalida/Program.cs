using System;

namespace _08_notavalida
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("Dime la nota");
            nota = double.Parse(Console.ReadLine());

            while (!EsNotaValida(nota))
            {
                Console.WriteLine("Nota no válida, vuélvela a escribir");
                nota = double.Parse(Console.ReadLine());
            }
        }
        
        static bool EsNotaValida(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
