using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_08_Library
{
    internal class Backpack : IBag<Book>
    {
        private List<Book> backpackStorage;

        public Backpack()
        {
            backpackStorage = new List<Book>();
        }

        public void Pack(Book item)
        {
            backpackStorage.Add(item);
        }

        // Unpack book by index
        public Book Unpack(int index)
        {
            if (index >= 0 && index < backpackStorage.Count)
            {
                Book unpackedBook = backpackStorage[index];
                backpackStorage.RemoveAt(index);
                return unpackedBook;
            }
            return null;
        }

        // Unpack book by title
        public Book Unpack(string title)
        {
            Book unpackedBook = backpackStorage.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (unpackedBook != null)
            {
                backpackStorage.Remove(unpackedBook);
            }
            return unpackedBook;
        }

        // Explicitly implemented to avoid naming conflict with the Library's Storage property
        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            return backpackStorage.GetEnumerator();
        }

        // Explicitly implemented to avoid naming conflict with the Library's Storage property
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return backpackStorage.GetEnumerator();
        }
    }
}
