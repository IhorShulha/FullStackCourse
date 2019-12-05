using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Программа загадывает число от 1 до 146. Пользователь пытается его угадать. 
             * В случае неверного ответа программа дает подсказку «больше» или «меньше»
             */

            var rand = new Random();

            int searchNumber = rand.Next(1,146);
            Console.WriteLine(searchNumber);

            while (true)
            {
             
                Console.WriteLine("Угадайте число от 1 до 146:");
                int i = Convert.ToInt32(Console.ReadLine());

                if (i == searchNumber)
                {
                    Console.WriteLine("Вы угадали");
                    break;
                }  
                else if (i > searchNumber)
                {
                    Console.WriteLine($"Число меньше, чем {i}");
                    continue;
                }
                else if(i < searchNumber)
                {
                    Console.WriteLine($"Число больше, чем {i}");
                    continue;
                }

            }
        }
    }
}
