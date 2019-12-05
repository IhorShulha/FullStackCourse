using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * У гусей и кроликов вместе 64 лапы. 
             * Сколько может быть кроликов и
             * гусей (указать все сочетания)?
             */

            int rabbit, goose = 64;

            Console.WriteLine("Hello World!");

            for (int i = 0; i <= goose; i++)
            {
                for(rabbit = 0; rabbit<= goose; rabbit++)
                {
                    if((4 * i) + (4 * rabbit) == goose)
                    {
                        Console.WriteLine($"Кроликов {i}. Гусей {rabbit}");
                    }
                }
            }

        }
    }
}
