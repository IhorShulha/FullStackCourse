using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xiaomi");
            Notebook xiaomi = new Notebook("Redmi Note7","China", 299.99);
            xiaomi.DisplayInfo();

            Console.WriteLine("Iphone");
            Notebook iphone = new Notebook("11Max Pro", "China", 1299.99);
            iphone.DisplayInfo();

            Console.ReadKey();
        }
    }
}
