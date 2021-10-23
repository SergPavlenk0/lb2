using System;

namespace OOP_LB2_7
{
    
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
            employee.Calculator(out double salary, out double tax);
            Console.WriteLine($"Имя: {employee.Name}\nФамилия: {employee.Surname}\nДолжность: {employee.Post}\nЗарплата: {salary}\nНалог: {tax} ");
            Console.ReadKey();
           


        }
    }
}
