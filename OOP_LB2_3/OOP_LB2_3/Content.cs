using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_3
{
    class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\nКонтент книги: {content}. ");
            Console.ResetColor();
        }
    }
}
