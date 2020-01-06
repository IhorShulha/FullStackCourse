using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    struct Notebook
    {
        public string model;
        public string manufacturer;
        public double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($" Model: {model} \n Manufacturer: {manufacturer} \n Price: {price}$");
        }
    }
}
