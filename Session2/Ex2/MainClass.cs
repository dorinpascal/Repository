namespace Ex2
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            BirdWatcher watcher1 = new BirdWatcher();
            BirdWatcher watcher2 = new BirdWatcher();
            DeafBirdWatcher deafWatcher = new DeafBirdWatcher();

            bird.BirdAction += watcher1.ReactToBird;
            bird.BirdAction += watcher2.ReactToBird;
            bird.BirdAction += deafWatcher.ReactToBird;
            
            bird.Run();
        }
    }
}