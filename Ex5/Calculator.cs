using System;
using System.Net.Sockets;

namespace Ex5
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
          
            return sum;
        }

        public int Maximum()
        {
           int x=Convert.ToInt32(Console.ReadLine());
           int y=Convert.ToInt32(Console.ReadLine());
            return Math.Max(x, y);

        }
    }
}