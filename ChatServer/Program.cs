using System;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server sv = new Server();
            sv.StartServer();
        }
    }
}