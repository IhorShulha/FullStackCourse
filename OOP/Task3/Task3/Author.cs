using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Author
    {
        public string BookAuthor { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Автор книги: {BookAuthor}");
            Console.ResetColor();
        }
    }
}
