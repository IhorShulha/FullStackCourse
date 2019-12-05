using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Требуется:
             * Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно
             * строковое поле и метод void Show().
             * Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
             * Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
             */

            Book book;

            Console.WriteLine("Введите Автора книги: ");
            string author = Console.ReadLine();

            Console.WriteLine("Введите название книги: ");
            string  title= Console.ReadLine();

            Console.WriteLine("Введите содержание книги: ");
            string content = Console.ReadLine();
            
            book = new Book(author, title, content);
            
            book.Show();
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
