using System;

namespace Funciones_proyecto2_LRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo, hora2, minuto2, segundo2, dia, mes, anno;
            Console.WriteLine("Introduce horas");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce minutos");
            minuto = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce segundos");
            segundo = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otra hora");
            hora2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otros minutos");
            minuto2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otros segundos");
            segundo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime un día");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un año superior a 1980");
            anno = int.Parse(Console.ReadLine());

            Console.WriteLine("Son en total " + HoraASegundos(hora, minuto, segundo) + " segundos" );
            EscribeHoraBonita(hora, minuto, segundo);
            EscribeSegundosBonito(segundo);
            Console.WriteLine("Los segundos transcurridos entre estas horas son : " + SegundosTranscurridos(hora, minuto, segundo, hora2, minuto2, segundo2));
            Console.WriteLine("Los segundos transcurridos desde 1980 hasta la fecha introducida son : " + SegundosTranscurridos1980(hora, minuto, segundo, dia, mes ,anno));

        }

        static int HoraASegundos(int hora, int minuto, int segundo)
        {
            int totalsegundos;

            totalsegundos = (hora * 3600) + (minuto * 60) + segundo;

            return totalsegundos;
        }

        static void EscribeHoraBonita(int hora, int minuto, int segundo)
        {
            if (minuto > 60 || minuto < 0 || segundo > 60 || segundo < 0)
            {
                Console.WriteLine("Error, escriba la hora dentro del intervalo establecido (0 - 60)");
            }
            else
            {
                Console.Write(hora+ ":");

                if (minuto < 10)
                {
                    Console.Write("0"+minuto+":");
                }
                else
                {
                    Console.Write(minuto+":");
                }

                if (segundo < 10)
                {
                    Console.Write("0" + segundo);
                }
                
            }

            Console.WriteLine();
        }

        static void EscribeSegundosBonito(int segundototales)
        {
            int hora, min, segundos, sobrantes;
            hora = segundototales / 3600;
            sobrantes = segundototales % 3600;

            min = sobrantes / 60;
            segundos = sobrantes % 60;

            EscribeHoraBonita(hora, min, segundos);
        }

        static int HoraASegundos2(int hora2, int minuto2, int segundo2)
        {
            int totalsegundos;

            totalsegundos = (hora2 * 3600) + (minuto2 * 60) + segundo2;

            return totalsegundos;
        }

        static int SegundosTranscurridos(int hora, int minuto, int segundo, int hora2, int minuto2, int segundo2)
        {
            int min, max, ts;

            if (HoraASegundos(hora, minuto, segundo) >= HoraASegundos2(hora2, minuto2, segundo2))
            {
                max = HoraASegundos(hora, minuto, segundo);
                min = HoraASegundos2(hora2, minuto2, segundo2);
            }
            else
            {
                max = HoraASegundos2(hora2, minuto2, segundo2);
                min = HoraASegundos(hora, minuto, segundo);
            }

            ts = max - min;

            return ts; 
        }

        static int SegundosTranscurridos1980(int hora, int minuto, int segundo, int dia, int mes, int anno)
        {
            int cuenta;

            cuenta = diastranscurridos1980(dia, mes, anno) * 86400;

            return cuenta;
        }

        static int diastranscurridos1980(int dias, int mes, int anno)
        {
            int i;
            int diastotales = 0;

            for (i = 1980; i < anno; i++)
            {
                if (EsBisiesto(anno))
                {
                    diastotales = diastotales + 366;
                }
                else
                {
                    diastotales = diastotales + 365;
                }
            }

            diastotales = diastotales + DiasTranscurridos(dias, mes, anno);

            return diastotales;

        }

        static int DiasTranscurridos(int dias, int mes, int anno)
        {
            int i, totaldias;
            totaldias = 1;

            for (i = 1; i < mes; i++)
            {
                totaldias = totaldias + DiasMes2(i, anno);
            }

            totaldias = totaldias + dias;

            return totaldias;
        }

        static int DiasMes2(int mes, int anno)
        {
            int dias;

            if (EsBisiesto(anno) && mes == 2)
            {
                dias = 29;
            }
            else
            {
                dias = DiasMes(mes);
            }

            return dias;
        }

        static int DiasMes(int mes)
        {
            int dias;
            if (mes >= 1 && mes <= 12)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 8 || mes == 10 || mes == 12)
                {
                    dias = 31;
                }
                else
                {
                    if (mes == 2)
                    {
                        dias = 28;
                    }
                    else
                    {
                        dias = 30;
                    }
                }
            }
            else
            {
                dias = 0;
                Console.WriteLine("ERROR");
            }

            return dias;

        }

        static bool EsBisiesto(int anno)
        {
            bool resultado;

            if (anno % 400 == 0)
            {
                resultado = true;
            }
            else
            {
                if (anno % 4 == 0 && anno % 100 != 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            return resultado;
        }

    }
}
