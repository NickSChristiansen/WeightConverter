using System;
using System.Runtime.CompilerServices;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Port number should be higher than 2048 as these are reserved for other protocols, but below 65535 which is the upper limit
            const int PORT = 2049;
            Console.WriteLine("Server Window");
            var server = new Server(PORT);
            server.Start();
            Console.ReadLine();
        }
    }
}
