using System;
using System.ComponentModel;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumb(10);
            Console.WriteLine();
            Console.WriteLine();
            OddNumber(10);
            Console.WriteLine();
            Console.WriteLine();
            DivisibleNumber(6,3);

        }

        public static void EvenNumb(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void OddNumber(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2!=0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        public static void DivisibleNumber(int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % y==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
    
