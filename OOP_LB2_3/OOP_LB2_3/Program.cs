using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_3
{
    public class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

    }
    public class Title
    {
        public string name;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Имя книги = {name}. ");
        }
    }
    public class Author
    {
        public string name;
        public void Show()
        {

        }
    }
    public class Content
    {
        public string name;
        public void Show()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
