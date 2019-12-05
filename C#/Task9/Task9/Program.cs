using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Сделать программу перевода валют. Вводится сумма, потом
             * выбирается вид валюты – гривны или доллары или евро, программа
             * переводит в две другие валюты. Текущий курс валюты считать известным.
             */

            Console.WriteLine("Введите сумму:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            decimal uah = default;
            decimal usd = 24.05M;
            decimal eur = 26.6M;

            while(true)
            {
                Console.WriteLine("Введите \"0\" для выбора доллара, \"1\" для выбора евро, \"2\" для выбора гривны");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    uah = usd * sum;
                    eur = (usd * sum) / eur;

                    Console.WriteLine($"Вы ввели {sum} USD это {uah} UAH и {eur} EUR");
                    break;
                } 
                else if(x == 1)
                {
                    usd = (eur * sum) / usd;
                    uah = eur * sum;

                    Console.WriteLine($"Вы ввели {sum} EUR это {usd} USD и {uah} UAH");
                    break;
                } 
                else if(x==2)
                {
                    usd = sum/usd;
                    eur = sum/eur;

                    Console.WriteLine($"Вы ввели {sum} UAH это {usd} USD и {eur} EUR");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы сделали неправильный выбор, попробуйте еще раз!");
                    continue;
                }
            }

        }
    }
}
