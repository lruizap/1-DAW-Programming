using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables enteras 

            // 1- Definir variable
            int entero;                 // es el que más se usa
            byte entero8;
            short entero16;
            long entero64;

            uint enterosinsigno32;      // unsorted int
            ushort enterosinsigno16;    // unsorted short int
            ulong ess32:                // unsorted long int
            sbyte byteentero;

            // 2- Guardar cosas en la variable
            entero = 1;

            // 3- Usar el valor que está guardado (console.writeline = cw tab tab)
            Console.WriteLine(entero);

            // 4- Modificar una variable 
            entero = entero + 1;
            Console.WriteLine(entero);


            // Variables reales

            // 1- Definir variable 
            double real;
            float realchungo;
            decimal realdinero;

            // 2- Guardar cosas en la variable 
            real = 3.1415926535;

            // 3- Usar el valor que está guardado
            Console.WriteLine(real);

            // 4- Modificar el valor 
            real = real * 2;
            Console.WriteLine(real);


            // Caracteres

            // 1- Def (derech 0, 'el caracter entre estas comillas')
            char caracter;

            // 2- Guardar 
            caracter = 'A';

            // 3- Usar
            Console.WriteLine(caracter);

            // 4- Operacion
            caracter = (char)(caracter + 1);
            Console.WriteLine(caracter);

            // cuidado con el orden de las los caracteres
            char caracter2;
            caracter2 = 'ñ';
            Console.WriteLine(caracter2);
            caracter2 = (char)(caracter2 + 1);
            Console.WriteLine(caracter2);


            // Cadenas 

            // 1- Def (+ de 1 char y se usan las comillas del 2 "hola")
            string cadena;

            // 2- Guardar
            cadena = "hola";

            // 3- Uso
            Console.WriteLine(cadena);

            // 4- Operaciones (para separar, espacio delante de la 2a cadena)
            cadena = cadena + " banana";
            Console.WriteLine(cadena);


            // Variables booleanas (solo 1 valor, 0 o 1, pero se escribe true o false)
            bool valor;
            valor = true;
            Console.WriteLine(valor);
            bool valor2;
            valor2 = false;
            Console.WriteLine(valor2);

            //ctrl + k + c para anotaciones
            //ctrl + k + u para quitarla 
       
        }
    }
}
