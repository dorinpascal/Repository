using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{public class Server
    {
        public static List<NetworkStream> Streams = new List<NetworkStream>();
        public void StartServer()
        {
            Console.WriteLine("Server is starting...");
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 2019);
            listener.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                ClientHandler clientHandler = new ClientHandler(client,stream);
                Thread thread = new Thread(clientHandler.Start);
                Console.WriteLine("Client accepted" );

                thread.Start();
            }
        }
    }
}