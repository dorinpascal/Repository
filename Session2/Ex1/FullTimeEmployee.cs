namespace Ex1
{
    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
       

        public FullTimeEmployee()
        {
            MonthlySalary = 0;
        }
      

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}