using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a > b ? a : b);
            Console.ReadKey();
        }
    }
}
