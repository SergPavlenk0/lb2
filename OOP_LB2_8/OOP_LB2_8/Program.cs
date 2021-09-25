using System;

namespace OOP_LB2_8
{
    public class Invoice
    {
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public double CalculateWith()
        {
            double price = 0d;

            switch (article)
            {
                case "West":
                    price = 10d;
                    break;
                case "East":
                    price = 50d;
                    break;
                case "North":
                    price = 200d;
                    break;
            }
            return price * quantity / 0.87d;
        }
        public double CalculateWithOut()
        {
            double price = 0d;

            switch (article)
            {
                case "West":
                    price = 10d;
                    break;
                case "East":
                    price = 50d;
                    break;
                case "North":
                    price = 200d;
                    break;
            }
            return price * quantity / 1d;
        }
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
