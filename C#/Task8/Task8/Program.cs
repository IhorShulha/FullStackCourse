using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете
             * 12-гранный кубик. Если выпадают значения от 1 до 5, пользователь
             * проиграл. Если выпадают значения от 6 до 8, пользователь получает
             * свою ставку обратно. Если выпало от 9 до 11, пользователь получает
             * двойную ставку, а если выпало 12 - ставку умноженную на 10. После
             * окончания игры покажите пользователю, сколько он выиграл.
             */

            var rand = new Random();

            Console.WriteLine("Введите сумму Вашей ставки:");
            int count = Convert.ToInt32(Console.ReadLine());

            int a = rand.Next(1,12);
            //Console.WriteLine(a);

            if (count > 0)
            {
                if (a <= 5)
                {
                    Console.WriteLine("Вы проиграли");
                }
                else if(a <= 8)
                {
                    Console.WriteLine($"Вы выиграли: {count}");
                }
                else if (a <= 11)
                {
                    Console.WriteLine($"Вы выиграли: {count*2}");
                }
                else
                {
                    Console.WriteLine($"Вы выиграли: {count * 10}");
                }
            }
            else
            {
                Console.WriteLine("Ваша ставка должна быть больше 0");
            }

        }
    }
}
