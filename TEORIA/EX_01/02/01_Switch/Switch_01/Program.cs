using System;

namespace Switch_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasemana = 1;

            switch (diasemana)
            {
                case 1: Console.WriteLine("Lunes");
                    break;

                case 2: Console.WriteLine("Martes");
                    break;

                case 3: Console.WriteLine("Miercoles");
                    break;

                    //... 

                default:
                    Console.WriteLine("ERROR");
                    break;   
            }
        }
    }
}
