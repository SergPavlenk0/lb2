using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2
{               
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Address address = new Address() { country = "Poland", city = "Wroclaw", index = "54705", house = "12", apartment = "44", street = "Olawska" };
            Console.WriteLine($"{address.country}, {address.city}, {address.index}, {address.house}, {address.apartment}, {address.street}");
            Console.ReadKey();
        }
    }
}
