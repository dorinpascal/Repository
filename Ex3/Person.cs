using System;

namespace Ex3
{
    public class Person
    {
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hi, I am  {0}",Name);
        }
        
    }
}