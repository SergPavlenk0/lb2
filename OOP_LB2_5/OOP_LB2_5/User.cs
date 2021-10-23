using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB2_5
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Логин: {Login}\n" + $"Имя: {Name}\n" + $"Фамилия: {Surname}\n" + $"Возраст: {Age}\n" + $"Дата заполнения анкеты: {Date}";
        }
    }
}
