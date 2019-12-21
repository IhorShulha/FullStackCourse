using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Printer
    {
        public string Value { get; set; }
        public Printer(string value)
        {
            Value = value;
        }


        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
