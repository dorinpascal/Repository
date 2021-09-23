using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    public class Server
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server is starting...");
            IPAddress ip=IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 1010);
            listener.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                
                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();
                
                //read

                byte[] dataFromClient = new byte[1024];
                int bytesToRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesToRead);
                Console.WriteLine(s);
                
                //respond

                byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                stream.Write(dataToClient,0,dataFromClient.Length);
                
                //close connection
                client.Close();

            }
            
        }
    }
}