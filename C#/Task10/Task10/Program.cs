using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вывести на экран таблицу умножения на N от 1 до 20 где N число
             * введенное пользователем 2. Пользователь вводит число вывести на
             * экран количество разрядов в этом числе
             */

            Console.WriteLine("Введите количество разрядов:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + $"*{n}=");
                for (int k = n; k<=n; k++)
                {
                    Console.Write("\t"+i*k);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
