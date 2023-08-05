using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_08_Library;

namespace Library_LAB08
{
    internal class Library : ILibrary
    {

        private Dictionary<string, Book> Storage;


        public Library()
        {
            Storage = new Dictionary<string, Book>();
            Book book1 = new Book("Killing Mr.Griffin", "SomeGuy");
            Book book2 = new Book("Monster", "SomeGuy");
            Book book3 = new Book("Beowolf", "SomeGuy");
            Storage.Add(book1.Title, book1);
            Storage.Add(book2.Title, book2);
            Storage.Add(book3.Title, book3);
        }

        public int Count => throw new NotImplementedException();

        int IReadOnlyCollection<Book>.Count => throw new NotImplementedException();

        public void Add(string title, string author)
        {
            Book newBook = new Book(title, $"{author} ");
            Storage.Add(newBook.Title, newBook);

        }

        public Book Borrow(string title)
        {
            if (Storage.TryGetValue(title, out Book book))
            {
                Storage.Remove(title);
                return book;
            }
            return null;

            throw new NotImplementedException();
        }


        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.Values.GetEnumerator();
        }

        public void Return(Book book)
        {
            if (book != null && !Storage.ContainsKey(book.Title))
            {
                Storage.Add(book.Title, book);
            }
        }

        public Book Search(string title)
        {
            bool storageTitle = Storage.ContainsKey(title);
            if (storageTitle == true)
            {
                return Storage[title];

            }
            return null;
        }

        public void ViewAllBooks()
        {
            var keys = Storage.Keys;
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                Console.WriteLine(key);

            }

        }

        void ILibrary.Add(string title, string firstName, string lastName, int numberOfPages)
        {
            throw new NotImplementedException();
        }

        Book ILibrary.Borrow(string title)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ILibrary.Return(Book book)
        {
            throw new NotImplementedException();
        }
    }
}