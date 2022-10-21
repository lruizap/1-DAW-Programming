using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace _02_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-servidor");
            Console.WriteLine("2-cliente");
            string s = Console.ReadLine();
            if (s == "1")
            {
                Servidor();
            }
            else
            {
                Cliente();
            }
            Console.WriteLine("pulse una tecla para acabar...");
            Console.ReadKey();
        }

        private static void Cliente()
        {
            TcpClient cliente = new TcpClient("127.0.0.1", 9999);
            StreamWriter sw = new StreamWriter(cliente.GetStream());
            sw.WriteLine("tomate");
            sw.Close();
            cliente.Close();
        }

        private static void Servidor()
        {
            //IPAddress ip = new IPAddress(new byte[] { 172, 30, 250, 97 });
            //IPEndPoint ep = new IPEndPoint(ip, 9999);
            TcpListener servidor = new TcpListener(9999);
            servidor.Start();
            TcpClient cliente = servidor.AcceptTcpClient();
            StreamReader sr = new StreamReader(cliente.GetStream());

            Console.WriteLine(sr.ReadLine());

            sr.Close();
            cliente.Close();
            servidor.Stop();
        }
    }
}
