using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MultiThreaded
{
    public class Server
    {
        public TcpListener Listener;

        public Server()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            Listener = new TcpListener(ip, 2019);
        }

        public void Start()
        {
            Console.WriteLine("Server is starting...");
            Listener.Start();
            Thread thread = new Thread(Run);
            thread.Start();
            Console.WriteLine("Waiting for a client...");
        }

        private void Run()
        {
            while (true)
            {
               
                TcpClient client = Listener.AcceptTcpClient();
                

                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();
                //read
                while (true)
                {
                    byte[] dataFromClient = new byte[1024];
                    int bytesToRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                    if (bytesToRead == 0)
                    {
                        Console.WriteLine("Client exits \n");
                        client.Close();
                        break;
                    }
                    else
                    {
                        string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesToRead);
                        Console.WriteLine(s);
                        //respond

                        byte[] dataToClient = Encoding.ASCII.GetBytes("From server :  " + s.ToUpper());
                        stream.Write(dataToClient, 0, dataToClient.Length);
                    }
                }
                

            }
        }
    }
}