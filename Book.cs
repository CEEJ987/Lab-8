using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book(string title, string v)
        {
            Title = title;
        }

        // Override ToString() to customize the book representation
        public override string ToString()
        {
            return $"{Title} by {Author}, {NumberOfPages} pages";
        }
    }
}