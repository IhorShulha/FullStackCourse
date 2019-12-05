using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Title
    {
        public string BookTitle { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Название книги: {BookTitle}");
            Console.ResetColor();
        }
    }
}
