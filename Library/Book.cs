using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        private string Title;
        private string Author;
        private int ISBN;

        //Parameterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
