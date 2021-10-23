using System;

namespace OOP_LB2_8
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
                Invoice invoice = new Invoice(account: 27, customer: "John Bodie", provider: "BKM", article: "East", quantity: 7);
                Console.WriteLine($"Сумма с НДС: {invoice.CalculateWith()}");
                Console.WriteLine($"Сумма без НДС: {invoice.CalculateWithOut()}");
                Console.ReadKey();
            }
        }
    }
}
