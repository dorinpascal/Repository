using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");
            TcpClient Client = new TcpClient("127.0.0.1", 2019);
            NetworkStream Stream = Client.GetStream();
            ServerHandler sv = new ServerHandler(Client);
            Thread thread = new Thread(sv.Start);
            thread.Start();
            
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //send message
            Message name2 = new Message(name);
            string json1 = JsonSerializer.Serialize(name2);
            byte[] dataToServer2 = Encoding.ASCII.GetBytes(json1);
            Stream.Write(dataToServer2, 0, dataToServer2.Length);
            
            bool x = true;
            Console.WriteLine("You can start chatting!");
            
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
                    Message ms = new Message(message);
                    string json = JsonSerializer.Serialize(ms);
                    byte[] dataToServer = Encoding.ASCII.GetBytes(json);
                    Stream.Write(dataToServer, 0, dataToServer.Length);
                }
            }

            //Stream.Close();
            Client.Close();
        }
    }
}