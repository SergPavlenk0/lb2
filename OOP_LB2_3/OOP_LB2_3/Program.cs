using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_3
{
     
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Title title1 = new Title() { name = "The Alchemist" };
            Author author1 = new Author() { author = "Paulo Coelho" };
            Content content1 = new Content() { content = "this book is about the search for truth" };
            Book book = new Book() { title = title1, author = author1, content = content1 };
            book.title.Show();
            book.author.Show();
            book.content.Show();

            Console.ReadKey();

        }
    }
}
