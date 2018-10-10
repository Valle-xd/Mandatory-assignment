using System;

namespace TCPServer
{
    class Program
    {
         static void Main(string[] args)
         {
             var server = new Server(4000);
             server.Start();
             Console.ReadKey();
        }
    
    }
}
