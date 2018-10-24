using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using GramsAndOunces;

namespace Server
{
    public class Server
    {
        private readonly int _port;

        public Server(int port)
        {
            this._port = port;
        }

        public void Start()
        {
            var serverListner = new TcpListener(IPAddress.Loopback, _port);
            serverListner.Start();

            while (true)
            {
                var socket = serverListner.AcceptTcpClient();
                {
                    var tempSocket = socket;
                    Task.Run(() =>
                    {
                        ServeClient(tempSocket);
                    });
                }
            }
        }

        public void ServeClient(TcpClient socket)
        {
            using (var streamReader = new StreamReader(socket.GetStream()))
            using (var streamWriter = new StreamWriter(socket.GetStream()))
            {
                
                // Read stream, split it, put in array
                var clientRequestString = streamReader.ReadLine();
                var clientRequestArray = clientRequestString.Split(' ');

                // Checking for valid syntax
                if (!clientRequestString.ToLower().Contains("togram") ||
                    !clientRequestString.ToLower().Contains("toounces"))
                {
                    streamWriter.WriteLine("Command not recognized");
                }
                else
                {
                    // Define index of method and value
                    var requestedMethod = clientRequestArray[0];
                    var valueToConvert = Convert.ToDouble(clientRequestArray[1]);

                    // Convert to desired type
                    var resultOfConversion = "";
                    if (requestedMethod.ToLower() == "togram")
                    {
                        resultOfConversion = $"{GramsOuncesConversion.OuncesToGrams(valueToConvert)} grams";
                    }
                    if (requestedMethod.ToLower() == "toounces")
                    {
                        resultOfConversion = $"{GramsOuncesConversion.GramsToOunces(valueToConvert)} ounces";
                    }

                    // Place result in outbound stream
                    streamWriter.WriteLine(resultOfConversion);
                }

                // Flush result to allow for next
                streamWriter.AutoFlush = true;

            }
            // If socket is not null, close it
            socket?.Close();
        }

    }
}
