using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.HomeWork
{
    public class Developer : Employee
    {
        protected int LinesOfCodePerDay { get; set; }
        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
        }
        public double CalculateAnnualSalary(int Days, double PriceForOneLineOfCode)
        {
            double bonus = LinesOfCodePerDay * Days * PriceForOneLineOfCode;
            return Salary * 12 + bonus;
        }
    }
}
