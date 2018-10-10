using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOGRAM/TOOUNCES <value>");
            var client = new Client(5000);
            client.Start();
            Console.ReadKey();
        }
    }
}
