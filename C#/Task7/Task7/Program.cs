using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int limit = Convert.ToInt32(Math.Sqrt(x));

            for (int i = 2; i <= limit; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Число составное");
                    break;
                } else
                {
                    Console.WriteLine("Число простое");
                    break;
                }
            }
            

        }
    }
}
