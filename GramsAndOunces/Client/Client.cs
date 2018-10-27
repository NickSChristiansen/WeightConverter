using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class Client
    {
        public void Start()
        {
            // Port number of the server - clients own port number is assigned by the OS
            using (var socket = new TcpClient("localhost", 2049))
            using (var networkStream = socket.GetStream())
            using (var streamReader = new StreamReader(networkStream))
            using (var streamWriter = new StreamWriter(networkStream))
            {
                // Read userinput
                var outboundString = Console.ReadLine();
                // Place userinput in outbound stream
                streamWriter.WriteLine(outboundString);
                //  Flush stream to allow new input to be read
                streamWriter.Flush();

                // Server response
                var inputString = streamReader.ReadLine();
                // Display server response
                Console.WriteLine("Result: " + inputString);
            }
        }
    }
}
