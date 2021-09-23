using System;

namespace ChatServerObj
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