using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB2
{   public class Address
    {

        public string country, city, index, house, apartment, street;

        public Address()
        {
            Country = country;
            City = city;
            Index = index;
            House = house;
            Apartment = apartment;
            Street = street;

        }

        private protected  string Country { get; set; }

        private protected  string City { get; set; }

        private protected  string Index { get; set; }

        private protected  string House { get; set; }

        private protected  string Apartment { get; set; }

        private protected  string Street { get; set; }

    }               
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
