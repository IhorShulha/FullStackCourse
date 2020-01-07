using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения в формате (день,месяц,год):");

            static void Main(string[] args)
            {
                DateTime toBirthday = new DateTime(2021,12,14);
                DateTime now = DateTime.Now;

                TimeSpan ts = toBirthday - now;
                int days = (int)ts.TotalDays;

                Console.WriteLine("До дня рожденья осталось: " + days + " дней!");
            }

        }
    }
}
