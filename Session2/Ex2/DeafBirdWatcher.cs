using System;

namespace Ex2
{
    public class DeafBirdWatcher
    {
        public void ReactToBird(string action)
        {
            switch (action)
            {
               
                case "Bird does mating dance" : Console.WriteLine("DeafWatcher :  Would you look at that");
                    break;
            }
        }
    }
}