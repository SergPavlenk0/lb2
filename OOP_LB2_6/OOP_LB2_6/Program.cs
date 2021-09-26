using System;

namespace OOP_LB2_6
{
    public class Converter
    {
        public double Eur { get; set; }
        public double Usd { get; set; }
        public double Rub { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public double ConvertToEur(double uah)
        {
            return uah * Eur;
        }
        public double ConvertToUsd(double uah)
        {
            return uah * Usd;
        }
        public double ConvertToRub(double uah)
        {
            return uah * Rub;
        }
        public double ConvertFromEur(double eur)
        {
            return Eur / eur;
        }
        public double ConvertFromUsd(double usd)
        {
            return Usd / usd;
        }
        public double ConvertFromRub(double rub)
        {
            return rub / Rub;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Converter converter = new Converter(usd: 1d / 26.73d, eur: 1d / 31.32d, rub: 1d / 0.37d);
            Console.WriteLine("Выберите желаемый вариант конвертации:");
            Console.WriteLine("1. Eur / Uah");
            Console.WriteLine("2. Usd / Uah");
            Console.WriteLine("3. Rub / Uah");
            Console.WriteLine("4. Uah / Eur");
            Console.WriteLine("5. Uah / Usd");
            Console.WriteLine("6. Uah / Rub");
            Console.WriteLine();

            Console.Write("Ваш выбор: ");
            int UserChoice;
            bool UserChoiceParsed = int.TryParse(Console.ReadLine(), out UserChoice);

            Console.Write("Количество единиц валюты: ");
            double value;
            bool valueParsed = double.TryParse(Console.ReadLine(), out value);


            Console.Write("Результат: ");

            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine(converter.ConvertFromEur(value));
                    break;


                case 2:
                    Console.WriteLine(converter.ConvertFromUsd(value));
                    break;


                case 3:
                    Console.WriteLine(converter.ConvertFromRub(value));
                    break;


                case 4:
                    Console.WriteLine(converter.ConvertToEur(value));
                    break;


                case 5:
                    Console.WriteLine(converter.ConvertToUsd(value));
                    break;


                case 6:
                    Console.WriteLine(converter.ConvertToRub(value));
                    break;
            }
            Console.ReadLine();


        }
    }
 
} 
