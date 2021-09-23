using System;
using System.Net.Sockets;
using System.Text;

namespace ClientEcho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client..");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();


            bool x = true;
            while (x)
            {
                string message=Console.ReadLine();
                if (message.Equals("exit"))
                {
                    x = false;
                }
                else
                {
                    byte[] dataToServer = Encoding.ASCII.GetBytes(message);
                    stream.Write(dataToServer,0,dataToServer.Length);
                    byte[] dataFromServer = new byte[1024];
                    int bytesToRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                    string response = Encoding.ASCII.GetString(dataFromServer,0, bytesToRead);
                    Console.WriteLine(response);
                }

                
            }
            
            stream.Close();
            client.Close();
        }
    }
}