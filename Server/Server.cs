using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Mandatory_assignment;

namespace TCPServer
{
    public class Server
    {
        private int _port;

        public Server(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var serverListener = new TcpListener(IPAddress.Loopback, _port);
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
                sw.AutoFlush = true;

                string[] incStrings = sr.ReadLine().Split(' ');


                string convertOption = incStrings[0].ToUpper();

                if (convertOption == "TOGRAM")
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converterdll.Ounces2Grams(weight);
                    sw.WriteLine(result);
                }
                else
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converterdll.Grams2Ounces(weight);
                    sw.WriteLine(result);
                }
            }
        }
    }
}
