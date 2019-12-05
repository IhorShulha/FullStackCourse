using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 целых чисел:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());


            int sum = a + b + c + d + e;
            double aver = sum / 5.0; 

            //Console.WriteLine(sum);
            Console.WriteLine($"Average: {aver}");
        }
    }
}
