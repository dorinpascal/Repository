using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeOutWord("[[]]","Yay"));
        }

        public static string MakeOutWord(string x, string y)
        {
           string s= x.Substring(0, 2);
           string c = x.Substring(2,2);
           return s + y + c;
        }
    }
}