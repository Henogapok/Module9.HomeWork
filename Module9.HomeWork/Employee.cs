using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.HomeWork
{
    public class Employee
    {
        public string Name {get; set; }
        protected int Age { get; set; }
        protected double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nSalary per month: {Salary}");
        }
        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
