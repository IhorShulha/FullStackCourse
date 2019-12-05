using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выведите все точные квадраты натуральных чисел, которые (квадраты)
             * меньше заданного числа N. (натуральные - это числа, которые мы
             * используем при счете: 1, 2, 3 и т.д.)
             */

            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                
                Console.Write($"\n{Math.Pow(i, 2)}");
            }
            Console.WriteLine();
            Console.ReadKey();
           
        }
    }
}
