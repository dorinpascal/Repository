using System;
using System.Threading;

namespace Ex2
{
    public class Bird
    {
        public Action<string> BirdAction;

        private string[] Actions = {"Bird flaps wings", "Bird sings", "Bird does mating dance"};

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int x = random.Next(3);
                switch (x)
                {
                    case 0 : Console.WriteLine(Actions[0]);
                        break;
                    case 1 :Console.WriteLine(Actions[1]);
                        break;
                    case 2:Console.WriteLine(Actions[2]);
                        break;
                }
                
                BirdAction?.Invoke(Actions[x]);
                Thread.Sleep(1000);
            }
        }
    }
}