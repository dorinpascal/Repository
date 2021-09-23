using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Substring("dorin",1));
        }

        public static string Substring(string a, int n)
        {
            string x=a.Substring(0, n);
            string y = a.Substring(a.Length - n, n);
            return x + y;
        }
    }
}