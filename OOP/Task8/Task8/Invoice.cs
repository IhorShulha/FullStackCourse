using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Invoice
    {
        int account;
        string customer;
        string provider;
        private int price;


        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
        }

        public string Article { get; set; } = default;
        public int Quantity { get; set; } = default;

        private double PriceWithTax()
        {
            return price * Quantity * 1.2;
        }
        private double PriceWithoutTax()
        {
            return (double)price * Quantity;
        }

        public override string ToString()
        {
            return "Account №" + account + "\nCustomer: " + customer + "\nProvider: " + provider + "\nProduct info:\narticle - " + Article
                + ", quantity - " + Quantity + ", price per unit - " + price + "\nTotal price without Tax: " + PriceWithoutTax().ToString() + ", with Tax : " + PriceWithTax().ToString();
        }
    }
}
