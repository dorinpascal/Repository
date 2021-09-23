using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ChatServerObj
{
    public class ClientHandler
    {
        private TcpClient Client;
        private NetworkStream Stream;


        public ClientHandler(TcpClient client, NetworkStream stream)
        {
            Client = client;
            Stream = stream;
            Server.Streams.Add(stream);
        }

        public void Start()
        {
            byte[] dataFromClient1 = new byte[1024];
            int byteToRead1 = Stream.Read(dataFromClient1, 0, dataFromClient1.Length);
            string name = Encoding.ASCII.GetString(dataFromClient1, 0, byteToRead1);
            Message name1 = JsonSerializer.Deserialize<Message>(name);

            byte[] dataToClient1 = Encoding.ASCII.GetBytes($"Message from Server : Hello  {name1.Body}");
            Stream.Write(dataToClient1, 0, dataToClient1.Length);

            while (true)
            {
                byte[] dataFromClient = new byte[1024];
                int byteToRead = Stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, byteToRead);
                Message json = JsonSerializer.Deserialize<Message>(s);
                Console.WriteLine(json);
                if (json.Body == "exit")
                {
                    Client.Close();
                    break;
                }
                else
                {
                    byte[] dataToClient = Encoding.ASCII.GetBytes($"Message from  {name1.Body} : {json}");
                    foreach (var Stream1 in Server.Streams)
                    {
                        if (!Stream1.Equals(Stream))
                        {
                            Stream1.Write(dataToClient, 0, dataToClient.Length);
                        }
                    }
                }
            }
        }
    }
}