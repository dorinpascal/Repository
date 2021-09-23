using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result("Hi", "Bye"));
            
        }

        public static String Result(string a, string b)
        {
            return String.Format("{0}{1}{2}{3}",a, b, a, b);
            
        }
    }
}