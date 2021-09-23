using System;
using System.Net.Sockets;
using System.Text;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");
            TcpClient Client = new TcpClient("127.0.0.1", 2019);
            NetworkStream Stream = Client.GetStream();
            bool x = true;
            while (x)
            {
                string message = Console.ReadLine();
                if (message.Equals("exit"))
                {
                    x = false;
                }
                else
                {
                    //send message
                    byte[] dataToServer = Encoding.ASCII.GetBytes(message);
                    Stream.Write(dataToServer, 0, dataToServer.Length);
                    byte[] dataFromServer = new byte[1024];

                    //recive message
                    int bytesToRead = Stream.Read(dataFromServer, 0, dataFromServer.Length);
                    string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesToRead);
                    Console.WriteLine(response);
                }
            }

            Stream.Close();
            Client.Close();
        }
    }
}