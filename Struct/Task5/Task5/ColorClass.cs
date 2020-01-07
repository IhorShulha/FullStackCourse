using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    static class ColorClass
    {
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.WriteLine("Default color of line");
                    break;
            }

            Console.WriteLine(line);
            
        }
    }
}
