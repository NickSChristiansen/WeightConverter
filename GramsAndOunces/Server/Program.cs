using System;
using System.Runtime.CompilerServices;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PORT = 7;
            Console.WriteLine("Server Window");
            var server = new Server(PORT);
            server.Start();
            Console.ReadLine();
        }
    }
}
