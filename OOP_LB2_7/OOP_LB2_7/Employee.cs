using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB2_7
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void Calculator(out double salary, out double tax)
        {
            double baseSalary = 0d;

            switch (Post)
            {
                case "Junior Developer":
                    baseSalary = 20000d;
                    break;
                case "Middle Developer":
                    baseSalary = 35000d;
                    break;
                case "Senior Developer":
                    baseSalary = 60000d;
                    break;
            }
            salary = baseSalary * Experience / 2d;
            tax = salary * 0.137d;
        }
    }
}
