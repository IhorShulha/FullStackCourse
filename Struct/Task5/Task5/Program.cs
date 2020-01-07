using System;

namespace Task5
{

    enum Colors { Yellow, Blue, Magenta }

    class Program
    {
        static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static int InputNumber()
        {
            string enter = null;
            int number = 0;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                enter = Console.ReadLine();
            } while (!int.TryParse(enter, out number) || number < 0 || number > 2);
            return number;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();

            Console.WriteLine("Выберите цвет где:\n 0 - Желтый\n 1 - Синий\n 2 - Розовый");
            int color = InputNumber();

            
            ColorClass.Print(line, color);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
