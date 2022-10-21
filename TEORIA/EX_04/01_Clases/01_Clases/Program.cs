using System;

namespace _01_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Alumno a = new Alumno();

            //a.nombre = "Paco";
            //a.calificacion = 4.75;
            //a.edad = 5;
            //Console.WriteLine(a.Aprobado());
            //a.AprobadoXLaCara();
            //Console.WriteLine(a.calificacion);
            //Console.WriteLine(a.Aprobado());

            //Alumno a2 = new Alumno();

            //a2.nombre = "Pedro";
            //a2.calificacion = 8;
            //a2.edad = 24;
            //Console.WriteLine(a2.Aprobado());

            //Alumno a3 = new Alumno("José", 8.5, 30);

            //pokemon p = new pokemon();

            //p.id = 1;
            //p.nombre = "Bulbasaur";
            //p.hpMax = 15;
            //p.hpActual = 15;
            //p.nivel = 1;
            //p.desmayado = false;

            //pokemon p = new pokemon(1, "Bulbasaur", SexoPokemon.macho ,TipoPokemon.Planta, 15, 15, 1);
            //pokemon p2 = new pokemon(1, "Squirtle", SexoPokemon.macho , TipoPokemon.Agua,13, 13, 1);
            //pokemon p3 = new pokemon(1, "Charmander", SexoPokemon.hembra , TipoPokemon.Fuego,12, 12, 1);

            //pokemon chungo = new pokemon(100, "Voltorb", SexoPokemon.desconocido , TipoPokemon.Normal,10, 9, 1);
            ////chungo.HpActual = 5;
            ////Console.WriteLine(chungo.HpActual);
            //Console.WriteLine(chungo.Desmayado);

            //p.HpActual = 0;
            //Console.WriteLine(p);
            //Console.WriteLine("vida = " + p.HpActual);
            //Console.WriteLine("Desmayado = " + p.Desmayado);
            //Console.WriteLine("Has usado poción");
            //p.BeberPocion();
            //Console.WriteLine("Se ha recuperado la vida");
            //Console.WriteLine("Vida = " + p.HpActual);
            //Console.WriteLine("Desmayado = " + p.Desmayado);

            //EquipoPokemon ep = new EquipoPokemon();
            //ep.InsertaPokemon(p);
            //ep.InsertaPokemon(p2);
            //ep.InsertaPokemon(p3);
            //ep.InsertaPokemon(chungo);
            //Console.WriteLine(ep);

            Coordenadas c1 = new Coordenadas(0, 5);
            Coordenadas c2 = new Coordenadas(5, 5);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 + 10);

            if (c1 == c2)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("son distintas");
            }
        }
    }
}
