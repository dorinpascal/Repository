using System;
using System.Linq;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
            char[] charArray = str2.ToCharArray();
            Array.Reverse( charArray );
            Console.WriteLine(charArray);
            string x = new string(charArray);
            if (str2.Equals(x))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            
            
           
        
        }
    }
}