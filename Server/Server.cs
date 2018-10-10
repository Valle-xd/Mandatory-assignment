using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Mandatory_assignment;

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

                string convertOption = incStrings[0].ToUpper();

                if (convertOption == "TOGRAM")
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converterdll.Ounces2Grams(weight);
                    sw.Write(result + "\n");
                }
                else
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converterdll.Grams2Ounces(weight);
                    sw.Write(result + "\n");
                }
            }
        }
    }
}
