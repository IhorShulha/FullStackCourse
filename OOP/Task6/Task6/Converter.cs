using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public double UAH { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd * 23.96;
            EUR = eur * 26.05;
            RUB = rub * 0.37;
        }

        public Converter(double uah)
        {
            USD = uah / 23.96;
            EUR = uah / 26.05;
            RUB = uah / 0.37;
        }
    }
}
