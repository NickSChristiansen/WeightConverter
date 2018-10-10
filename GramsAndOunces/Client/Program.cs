using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Window");
            var client = new Client();
            client.Start();
            Console.ReadLine();
        }
    }
}
