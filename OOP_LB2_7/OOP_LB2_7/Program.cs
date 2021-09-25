using System;

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
        public void Calculator(double salary, double tax)
        {
            salary = 
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Employee employee = new Employee("Mike", "Grant")
            {
                Post = "Middle Developer",
                Experience = 5
            };


        }
    }
}
