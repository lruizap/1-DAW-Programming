using System;

namespace Fechas
{
    class Program
    {
        static int SegundosTranscurridos1980(int anno,int mes ,int dia,int hora,int minutos,int segundos )
        {
            int segundos1980,segundoshora,segundostotales;

            segundos1980 =  (DiasTranscurridos1980(anno, mes,dia)-1)*86400;

            segundoshora= HorasASegundos(hora,minutos,segundos);

            segundostotales = segundos1980 + segundoshora;


            return segundostotales;









        }
        static int SegundosTranscurridos(int hora, int minutos, int segundos, int hora2, int minutos2, int segundos2)
        {
            int segundostrsnacurridos, segundostotales1, segundostotales2;

            segundostotales1 = HorasASegundos(hora, minutos, segundos);

            segundostotales2 = HorasASegundos(hora2, minutos2, segundos2);

            segundostrsnacurridos = segundostotales2 - segundostotales1;

            return segundostrsnacurridos;



        }
        static void EscribeSegundosBonito(int segundos)
        {
            int horas, minutos, segundossobrantes;

            horas = segundos / 3600;


            segundossobrantes = (segundos % 3600);



            minutos = segundossobrantes / 60;


            segundos = (segundos % 60);

            Console.WriteLine(horas + ": " + minutos + ": " + segundos);



        }
        static void EscribeSegundosBonito2(int segundos)
        {
            int horas = 0, minutos = 0, segundoss;

            while (segundos > 3600)
            {
                segundos = segundos - 3600;

                horas++;

            }
            while (segundos > 60)
            {
                segundos = segundos - 60;

                minutos++;

            }

            segundoss = segundos;
            Console.WriteLine(horas + ": " + minutos + ": " + segundoss);

        }
        static void EscribeHoraBoita(int hora, int minutos, int segundos)
        {

            Console.WriteLine(hora + ": " + minutos + ": " + segundos);

        }
        static int HorasASegundos(int hora, int minutos, int segundos)
        {
            int segundostotales;

            segundostotales = hora * 3600 + minutos * 60 + segundos;

            return segundostotales;




        }
        static int DiaSemanaFecha(int dia, int mes, int anno)
        {
            int diastotales;

            diastotales = DiasTranscurridos1980(dia, mes, anno);


            while (diastotales >= 7)
            {
                diastotales = diastotales - 7;


            }

            return diastotales + 1;
        }
        static int DiasEntreFechas(int dias, int meses, int annos, int dias2, int meses2, int annos2)
        {
            int diastrnscurridos = 0;


            diastrnscurridos = DiasTranscurridos1980(dias, meses, annos)
                - DiasTranscurridos1980(dias2, meses2, annos2);

            return diastrnscurridos;


        }
        static int DiasTranscurridos1980(int dias, int meses, int annos)
        {
            int i, diastrnscurridos = 0;

            for (i = 1980; i < annos; i++)
            {

                if (Bisiesto(i))
                {
                    diastrnscurridos = diastrnscurridos + 366;
                }
                else
                {
                    diastrnscurridos = diastrnscurridos + 365;

                }


            }

            diastrnscurridos = diastrnscurridos + DiasTranscurridos(dias, meses, annos);

            return diastrnscurridos;




        }
        static int DiasTranscurridos(int dias, int meses, int annos)
        {
            int diastranscurridos = 0, i;


            for (i = 1; i < meses; i++)
            {
                diastranscurridos = diastranscurridos + DiaMes2(i, annos);

            }


            diastranscurridos = diastranscurridos + dias;

            return diastranscurridos;






        }
        static bool Bisiesto(int anno)
        {
            bool resultado;


            if (anno % 4 == 0)
            {
                if (anno % 100 != 0)
                {


                    if (anno % 400 == 0)
                    {

                        resultado = true;

                    }
                    else
                    {

                        resultado = false;
                    }
                    resultado = true;

                }
                else
                {
                    resultado = false;



                }



            }
            else
            {
                resultado = false;


            }



            return resultado;

        }

        static int DiaMes2(int mes, int anno)
        {
            int dia;

            if (Bisiesto(anno))
            {
                if (mes == 2)
                {

                    dia = 29;

                }
                else
                {

                    dia = DiaMes(mes);

                }



            }
            else
            {
                dia = DiaMes(mes);


            }


            return dia;



        }
        static int DiaMes(int mes)
        {
            int dias = 0;
            switch (mes)
            {
                case 1:
                    dias = 31;
                    break;
                case 2:

                    dias = 28;
                    break;
                case 3:
                    dias = 31;
                    break;
                case 4:
                    dias = 30;
                    break;
                case 5:
                    dias = 31;
                    break;
                case 6:
                    dias = 30;
                    break;
                case 7:
                    dias = 31;
                    break;
                case 8:
                    dias = 31;
                    break;
                case 9:
                    dias = 30;
                    break;
                case 10:
                    dias = 31;
                    break;
                case 11:
                    dias = 30;
                    break;
                case 12:
                    dias = 31;
                    break;
                default:

                    break;
            }

            return dias;




        }
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Dime la función que quieres probar");
            num = int.Parse(Console.ReadLine());



            switch (num)
            {
                case 1:
                    {
                        //21. Escribe una función “DiasMes”, a la que le pasamos un mes (en formato numérico
                        // 1 = Enero, 2 = Febrero, etc.)y nos dice el número de días que tiene ese mes.
                        int mes;
                        Console.WriteLine("Dime el mes");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine(DiaMes(mes));


                    }
                    break;


                case 2:
                    {
                        //Debido a que en los años bisiestos el mes de Febrero tiene 29 días en lugar de 28,
                        //necesitaremos también dar el año para conseguir el resultado correcto. Escribe la
                        //función “DiasMes2” a la que le pasas un mes y un año(ambos enteros) y te dice
                        //cuántos días tiene ese mes, teniendo en cuenta si el año es bisiesto o no(NOTA:
                        //Podéis usar la función “Bisiesto” que hicimos con anterioridad).
                        int mes, anno;
                        Console.WriteLine("Dime el mes");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        anno = int.Parse(Console.ReadLine());
                        Console.WriteLine(DiaMes2(mes, anno));

                    }

                    break;
                case 3:
                    {
                        //. Escribe una función “DiasTranscurridos” a la que le pasamos tres enteros, el día, el
                        //mes y el año, y nos dice cuántos días han pasado desde el inicio del año hasta ese día.
                        //Así, el 1 de enero será el día 1 y el 31 de diciembre será el 365 ó 366 dependiendo de
                        //si el año es bisiesto o no.

                        int dias, meses, annos;
                        Console.WriteLine("Dime los días");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los meses");
                        meses = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        annos = int.Parse(Console.ReadLine());

                        Console.WriteLine(DiasTranscurridos(dias, meses, annos));





                    }

                    break;
                case 4:
                    {

                        //. Escribe una función “DiasTranscurridos1980” a la que le pasamos un día, mes y año y
                        //nos diga cuántos días han transcurrido desde el 01 / 01 / 1980 hasta ese día

                        int dias, meses, annos;
                        Console.WriteLine("Dime los días");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los meses");
                        meses = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        annos = int.Parse(Console.ReadLine());

                        Console.WriteLine(DiasTranscurridos1980(dias, meses, annos));
                    }

                    break;
                case 5:
                    {
                        //Escribe una función “DiasEntreFechas” a la que le pasamos 6 enteros.Un día, mes y
                        //año y otro día, mes y año, y nos dice cuántos días han pasado entre ambas fechas
                        int dias, meses, annos, dias2, meses2, annos2;
                        Console.WriteLine("Dime dos fechas y te calculos los días trasncurridos entre ambos");

                        Console.WriteLine("Dime los días");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los meses");
                        meses = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        annos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los días");
                        dias2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los meses");
                        meses2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        annos2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(DiasEntreFechas(dias, meses, annos, dias2, meses2, annos2));
                    }
                    break;
                case 6:
                    {
                        //Teniendo en cuenta que el 01 / 01 / 1980 era martes, haz una función
                        //“DiaSemanaFecha” que nos devuelva qué día de la semana corresponde a la fecha
                        //(día, mes y año) que le pasamos en 3 parámetros.Nos devolverá un entero que
                        //corresponderá al día de la semana(1 = lunes, 2 = martes, etc.)
                        int dia, mes, anno;
                        Console.WriteLine("Dime los días");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los meses");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime el año");
                        anno = int.Parse(Console.ReadLine());
                        Console.WriteLine(DiaSemanaFecha(dia, mes, anno));
                    }
                    break;
                case 7:
                    {
                        //Escribe una función “HoraASegundos” a la que le pasas 3 parámetros enteros (hora,
                        //minutos y segundos) y te devuelve el total de segundos.
                        int hora, minutos, segundos;
                        Console.WriteLine("Dime los horas");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los minutos");
                        minutos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los segundos");
                        segundos = int.Parse(Console.ReadLine());
                        Console.WriteLine(HorasASegundos(hora, minutos, segundos));

                    }
                    break;

                case 8:
                    {
                        // Escribe una función “EscribeHoraBonita” a la que le pasas tres parámetros(hora,
                        //minutos y segundos) y te escribe por pantalla la hora en formato “HH: MM: SS”

                        int hora, minutos, segundos;
                        Console.WriteLine("Dime los horas");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los minutos");
                        minutos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los segundos");
                        segundos = int.Parse(Console.ReadLine());
                        EscribeHoraBoita(hora, minutos, segundos);

                    }
                    break;

                case 9:
                    { //Escribe una función “EscribeSegundosBonito” a la que le pasas un parámetro que
                      //corresponde al número de segundos y te escribe por pantalla la hora en formato
                      //“HH: MM: SS”



                        int segundos;

                        Console.WriteLine("Dime los segundos");
                        segundos = int.Parse(Console.ReadLine());
                        EscribeSegundosBonito(segundos);


                    }
                    break;

                case 10:
                    {
                        //33. Escribe una función “SegundosTranscurridos” a la que le pasas 2 horas (en total, 6
                        //parámetros: hora, minutos y segundos para cada una de las dos horas) y te dice
                        //cuántos segundos han transcurrido entre una y otra.


                        int hora, minutos, segundos, hora2, minutos2, segundos2;
                        Console.WriteLine("Dime los horas");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los minutos");
                        minutos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los segundos");
                        segundos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los horas");
                        hora2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los minutos");
                        minutos2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los segundos");
                        segundos2 = int.Parse(Console.ReadLine());

                        SegundosTranscurridos(hora, minutos, segundos, hora2, minutos2, segundos2);


                    }
                    break;


                case 11:
                    {
                        //. Escribe una función “SegundosTranscurridos1980” a la que le pasas 6 parámetros: día,
                        //mes, año, hora, minutos y segundos y te dice cuántos segundos han transcurrido
                        //desde el 1 de enero de 1980.

                        int anno, mes, dia, hora, minutos, segundos;

                        Console.WriteLine("Dime los horas");
                        anno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los horas");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los horas");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los horas");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los minutos");
                        minutos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime los segundos");
                        segundos = int.Parse(Console.ReadLine());


                        SegundosTranscurridos1980(anno,mes,dia,hora,minutos,segundos);




                    }
                    break;
                default:

                    break;
            }
        }
    }
}

