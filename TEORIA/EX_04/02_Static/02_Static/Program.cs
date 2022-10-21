using System;

namespace _02_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- static --

            // métodos estáticos
            // atributos estático
            // constructor estát
            // státicos --

            // método que no usa los atributos de la clase, por lo tanto no necesita estar dentro de un objeto para poder ejecutarse

            //Class1 c = new Class1();
            //Console.WriteLine(c.mcd(45,45));

            //Console.WriteLine(Class1.mcd2(45, 60));

            // -- atributos estáticos --

            // atributos normales en los objetos y cada objeto tiene una copia de su atributo
            // los atributos estáticos estan en la clase en vez de en el objeto

            // -- clases estáticas --

            // una clase que no puede tener objetos --> biblioteca de funciones

            // -- constructor estático --

            // no pueden tener parámetros ya que no se pueden llamar. Se ejecutan cuando haga flata
            // Sirven para inicializar algo que sea estático
        }
    }
}
