using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_3
{
    class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nАвтор книги: {author}. ");
            Console.ResetColor();
        }
    }
}
