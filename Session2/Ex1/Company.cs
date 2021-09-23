using System.Collections.Generic;

namespace Ex1
{
    public class Company
    {
        private List<Employee> Employee;

        public Company()
        {
            Employee = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double temp =0;
            for (int i = 0; i < Employee.Count; i++)
            {
                temp += Employee[i].GetMonthlySalary();
            }

            return temp;
        }

        public void HireNewEmployee(Employee temp)
        {
            Employee.Add(temp);
        }
        
    }
}