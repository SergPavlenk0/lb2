using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2_2
{
    
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            double side1, side2;

            Console.WriteLine("Введіть значення першої сторони:");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення другої сторони:");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа =  {rectangle.Area}, Периметр = {rectangle.Perimeter}");
            Console.ReadKey();

        }
    }
}
