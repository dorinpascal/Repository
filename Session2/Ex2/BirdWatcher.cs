using System;

namespace Ex2
{
    public class BirdWatcher
    {
        public void ReactToBird(string action)
        {
            switch (action)
            {
                case "Bird flaps wings": Console.WriteLine("Ooh");
                    break;
                case "Bird sings" : Console.WriteLine("How nice");
                    break;
                case "Bird does mating dance" : Console.WriteLine("Would you look at that");
                    break;
            }
        }
    }
}