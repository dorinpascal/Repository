using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    public class ServerHandler
    {
        private TcpClient Client;
        private NetworkStream Stream;
        public ServerHandler(TcpClient client)
        {
            Client = client;
            Stream = Client.GetStream();
        }
        public void Start()
        {
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int byteToRead = Stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, byteToRead);
                Console.WriteLine(response); 
            }
        }
    }
}