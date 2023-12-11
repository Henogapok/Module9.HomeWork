using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Valeriy", 21, 150000, 50000);
            Developer dev = new Developer("Danila", 21, 300000, 50);

            manager.GetInfo();
            dev.GetInfo();

            Console.WriteLine($"{manager.Name}'s year salary is {manager.CalculateAnnualSalary(5)}");
            Console.WriteLine($"{dev.Name}'s year salary is {dev.CalculateAnnualSalary(70, 100)}");
        }
    }
}
