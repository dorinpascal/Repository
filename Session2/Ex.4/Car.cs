namespace Ex._4
{
    public class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public bool IsManuelShift { get; set; }

        

        public Car()
        {
            this.Color = "";
            EngineSize = 0;
            IsManuelShift = false;
        }


        public override string ToString()
        {
            return
                $"{nameof(Color)}: {Color}, {nameof(EngineSize)}: {EngineSize}, {nameof(IsManuelShift)}: {IsManuelShift}";
        }
    }
}