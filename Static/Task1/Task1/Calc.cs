using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class Calc
    {
        public static double x { get; set; }
        public static double y { get; set; }
        public static char calculators { get; set; }

        public static double addition(double x, double y) => x + y;
        public static double subtraction(double x, double y) => x - y;
        public static double multiplication(double x, double y) => x * y;
        public static double division(double x, double y) => x / y;

        public static void Calculator()
        {
            Console.WriteLine("Выберите:");
            Console.WriteLine(" + , - , * , / ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Введите ваше выражение:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваше выражение:");
            calculators = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите ваше выражение:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            switch (calculators)
            {
                case '+':
                    Console.WriteLine(addition(x, y));
                    break;
                case '-':
                    subtraction(x, y);
                    break;
                case '*':
                    multiplication(x, y);
                    break;
                case '/':
                    division(x, y);
                    break;
            }
        }
    }
}
