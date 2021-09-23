using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] {8, 3, 20, 3, 5};
            int small = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (small>list[i])
                {
                    small = list[i];
                }
            }

            int largest = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (largest<list[i])
                {
                    largest = list[i];
                }
            }
            
            Console.WriteLine(largest-small);

        }
    }
}