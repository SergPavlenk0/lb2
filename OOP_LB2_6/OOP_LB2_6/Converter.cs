using System;
using System.Collections.Generic;
using System.Text;

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
}
