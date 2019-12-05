using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "root";

            while(true)
            {
                Console.WriteLine("Введите Ваш пароль: ");
                string i = Console.ReadLine();

                if (i != pass)
                {
                    Console.WriteLine("Неверный пароль, попробуйте еще раз!");
                    continue;
                } else
                {
                    Console.WriteLine("Пароль верный!");
                    break;
                }
            }
        }
    }
}
