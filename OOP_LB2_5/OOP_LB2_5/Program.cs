using System;

namespace OOP_LB2_5
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Console.Write("Логин: ");
            string login = Console.ReadLine();

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User( login, name, surname, age);          
            Console.WriteLine("Заполненная анкета:");
            Console.WriteLine(user);
            Console.ReadLine();
        }
    }
}
