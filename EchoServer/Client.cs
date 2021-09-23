using System;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    public class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client..");

            TcpClient client = new TcpClient("127.0.0.1", 1010);

            NetworkStream stream = client.GetStream();

            byte[] dataToServer = Encoding.ASCII.GetBytes("Hello from client");
            stream.Write(dataToServer,0,dataToServer.Length);

            byte[] dataFromServer = new byte[1024];
            int bytesToRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer,0, bytesToRead);
            
            Console.WriteLine(response);
            stream.Close();
            client.Close();
        }
    }
}