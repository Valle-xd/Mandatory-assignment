using System;

namespace TCPServer
{
    class Program
    {
         static void Main(string[] args)
         {
             var server = new Server.Server(2000);
             server.Start();
             Console.ReadKey();
        }
    
    }
}
