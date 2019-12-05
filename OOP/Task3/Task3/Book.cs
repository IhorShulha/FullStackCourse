using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        public Content Cont { get; set; }
        public Title Title { get; set; }
        public Author Auth { get; set; }

        public void Show()
        {
            Auth.Show();
            Cont.Show();
            Title.Show();
        }

        public Book(string autName, string bookTitle, string bookContent)
        {
            Cont = new Content();
            Auth = new Author();
            Title = new Title();
            
            Cont.BookContent = bookContent;
            Auth.BookAuthor = autName;
            Title.BookTitle = bookTitle;
        }
    }
}
