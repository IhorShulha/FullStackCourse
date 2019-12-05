using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Content
    {
        public string BookContent { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Содержание книги: {BookContent}");
            Console.ResetColor();
        }
    }
}
