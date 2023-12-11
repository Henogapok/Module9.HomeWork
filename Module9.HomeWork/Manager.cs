using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.HomeWork
{
    public class Manager : Employee
    {
        protected double Bonus { get; set; }
        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            Bonus = bonus;
        }
        public double CalculateAnnualSalary(int CountOfProjects)
        {
            double bonus = Bonus * CountOfProjects;
            return Salary * 12 + bonus;
        }
    }
}
