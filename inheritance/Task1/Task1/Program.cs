using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Printer printer1 = new Printer("Test1");
            Text text = new Text("Test222");
            text.Print("1");
        }
    }
}
