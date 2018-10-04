using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        private readonly int PORT;

        public Server(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            var serverListener = new TcpListener(IPAddress.Loopback, PORT);
            serverListener.Start();
            while (true)
            {
                var client = serverListener.AcceptTcpClient();
                Task.Run(() => Handler(client));
            }
        }

        private void Handler(TcpClient client)
        {
            while (client.Connected)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.Flush();
                string[] incStrings;
                {
                    incStrings = sr.ReadLine().Split(' ');
                }
            }
        }
    }
}
