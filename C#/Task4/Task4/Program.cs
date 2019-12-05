using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Пользователь вводит число 1 или 0 с помощью одной строки кода
             * вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо»
             * если пользователь ввел 0
             */

            Console.WriteLine("Введите 1 или 0");
            byte a = Convert.ToByte(Console.ReadLine());

            string output = (a == 1) ? "Хорошо" : (a == 0) ? "Плохо" : "Введите 1 или 0";

            Console.WriteLine(output);
        }
    }
}
