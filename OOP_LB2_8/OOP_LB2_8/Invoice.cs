using System;
using System.Collections.Generic;
using System.Text;

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

