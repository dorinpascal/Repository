using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int[] list = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine(calculator.Add(list));
            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine(calculator.Maximum());
        }
    }
}