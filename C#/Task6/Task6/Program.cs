using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Служба такси заказала вам программу, которая спрашивает количество
             * километров и количество минут простоя, а дальше считает так: первые
             * 5 километров (или до 5 км) 20 гривен, каждый следующий километр 3
             * гривны, плюс простой 1 грн за 1 минуту. Программа должна посчитать
             * и сказать общую сумму оплаты за поездку.
             */

            Console.WriteLine("Введиет количество километров:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введиете количество минут простоя:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a <= 5)
            {
                a = a * 20;
            } 
            else if (a > 5)
            {
                a = (5 * 20) + ((a - 5) * 3);
            }

            b = a + ( b* 1);

            Console.WriteLine($"К оплате: {b} грн.");
         
        }
    }
}
