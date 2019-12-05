using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите \"гав\" или \"мяу\":");
            string word = Console.ReadLine();

            if (word == "мяу")
            {
                Console.WriteLine("Покорми кота");
            } 
            else if (word == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            } else {
                Console.WriteLine("Вы ввели неверное значение");
            }
        }
    }
}
