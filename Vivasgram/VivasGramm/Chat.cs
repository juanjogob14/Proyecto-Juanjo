using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace VivasGramm
{
    public class Chat
    {
        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
        private List<Connection> list = new List<Connection>();
        public List<string> nombresConectados = new List<string>();

        Connection con;

        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamw;
            public StreamReader streamr;
            public string nick;
            public string pass;
        }

        public Chat()
        {
            Inicio();
        }
        public void Inicio()
        {
            Console.WriteLine("Servidor en marcha");
            server = new TcpListener(ipendpoint);
            server.Start();

            while (true)
            {
                client = server.AcceptTcpClient();

                con = new Connection();
                con.stream = client.GetStream();
                con.streamr = new StreamReader(con.stream);
                con.streamw = new StreamWriter(con.stream);


                con.nick = con.streamr.ReadLine();
                con.pass = con.streamr.ReadLine();

                nombresConectados.Add(con.nick);
                list.Add(con);

                con.streamw.WriteLine("Bienvenido a Vivasgram "+con.nick+" ! \n" +
                    ""+list.Count+" usuario(s) conectados en el momento de tu conexión.");
                con.streamw.Flush();

                Console.WriteLine(con.nick + " se ha conectado.");


                Thread t = new Thread(Escuchar_conexion);
                t.Start();

            }
        }
        void Escuchar_conexion()
        {
            Connection hcon = con;

            do
            {
                try
                {
                    string mensaje = hcon.streamr.ReadLine();

                    Console.WriteLine(hcon.nick + ": " + mensaje);
                        foreach (Connection c in list)
                        {
                            try
                            {
                                c.streamw.WriteLine(hcon.nick + ": " + mensaje);

                                if (mensaje == "!usuarios")
                                {
                                    c.streamw.WriteLine("Usuarios conectados:");
                                    for (int i = 0; i < list.Count; i++)
                                    {
                                        c.streamw.WriteLine(list[i].nick);
                                    }
                                }
                                if (mensaje == "!now")
                                {
                                    c.streamw.WriteLine("Fecha y hora actuales \n"+DateTime.Now);
                                }

                                c.streamw.Flush();
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                }
                catch
                {
                    list.Remove(hcon);
                    nombresConectados.Remove(hcon.nick);
                    Console.WriteLine(con.nick + " se ha desconectado.");
                    break;
                }
            } while (true);
        }
    }
}



