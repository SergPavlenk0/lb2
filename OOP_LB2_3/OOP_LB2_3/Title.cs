using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_3
{
    class Title
    {
        public string name;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\nИмя книги: {name}. ");
            Console.ResetColor();
        }
    }
}
