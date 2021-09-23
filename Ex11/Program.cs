using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] {1, 1, 1, 2,2};
            Console.WriteLine(CountClumps(list));
            
        }

        public static int CountClumps(int[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                bool x = false;
               
                    while (i+1!=list.Length && list[i]==list[i+1])
                    {
                        
                        x = true;
                        i++;
                    }

                    if (x==true)
                    {
                        count++;
                    }    
                
                
            }

            return count;
        }
    }
}