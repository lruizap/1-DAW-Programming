using System;

namespace _01_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR

            int i;

            i = 0;                // inicialización del contador

            while (i < 10)        // condición del contador
            {
                Console.WriteLine(i);
                i++;              // incremento del contador
            }

            // equivalentee a 

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (; i < 20; i++)
            {
                Console.WriteLine(i);
            }

            for (; ;)
            {
                Console.WriteLine(i);
            }

        }
    }
}
