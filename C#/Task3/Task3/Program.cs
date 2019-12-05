using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите № месяца:");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 12 || month == 1 || month == 2 )
            {
                Console.WriteLine("Зима");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (month == 5 || month == 6 || month == 7)
            {
                Console.WriteLine("Лето");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }
        }
    }
}
