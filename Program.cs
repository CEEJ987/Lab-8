using System;

namespace Lab_08_Library
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            Backpack backpack = new Backpack();

            // Load initial books into the library
            LoadBooks(library);

            while (true)
            {
                Console.WriteLine("Hello! Welcome to my Library");
                Console.WriteLine("Pick an option:");
                Console.WriteLine("1: View Books");
                Console.WriteLine("2: Add Book");
                Console.WriteLine("3: Check out Book");
                Console.WriteLine("4: Return Book");
                Console.WriteLine("5: View Book Bag");
                Console.WriteLine("6: Exit");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Library Books:");
                            foreach (var book in library)
                            {
                                Console.WriteLine(book);
                            }
                            break;

                        case 2:
                            AddBook(library);
                            break;

                        case 3:
                            BorrowBook(library, backpack);
                            break;

                        case 4:
                            ReturnBook(library, backpack);
                            break;

                        case 5:
                            Console.WriteLine("Books in your Backpack:");
                            int count = 1;
                            foreach (var book in backpack)
                            {
                                Console.WriteLine($"{count}: {book.Title} by {book.Author}, {book.NumberOfPages} pages");
                                count++;
                            }
                            break;

                        case 6:
                            Console.WriteLine("Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option number.");
                }
            }
        }

        // Helper method to load initial books into the library
        static void LoadBooks(Library library)
        {
            library.Add("Homestuck", "Andrew", "Hussie", 8123);
            library.Add("dead dead demon's dededede destruction vol 1", "Inio", "Asano", 196);
            library.Add("Maximum Ride: 1", " James", "Patterson", 256);
        }

        // Helper method to add a book to the library
        static void AddBook(Library library)
        {
            Console.WriteLine("Enter the title of the book:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the author's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the author's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the number of pages:");
            if (int.TryParse(Console.ReadLine(), out int numberOfPages))
            {
                library.Add(title, firstName, lastName, numberOfPages);
                Console.WriteLine("Book added to the library.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of pages.");
            }
        }

        // Helper method to borrow a book from the library
        static void BorrowBook(Library library, Backpack backpack)
        {
            Console.WriteLine("Enter the title of the book to borrow:");
            string borrowTitle = Console.ReadLine();
            Book borrowedBook = library.Borrow(borrowTitle);
            if (borrowedBook != null)
            {
                backpack.Pack(borrowedBook);
                Console.WriteLine($"You have borrowed {borrowedBook.Title}.");
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
        }

        // Helper method to return a book to the library
        static void ReturnBook(Library library, Backpack backpack)
        {
            Console.WriteLine("Enter the number of the book to return:");
            if (int.TryParse(Console.ReadLine(), out int bookNumber) && bookNumber >= 1 && bookNumber <= backpack.Count())
            {
                Book returnedBook = backpack.Unpack(bookNumber - 1);
                if (returnedBook != null)
                {
                    library.Return(returnedBook);
                    Console.WriteLine($"You have returned {returnedBook.Title}.");
                }
                else
                {
                    Console.WriteLine("Book not found in your backpack.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid book number.");
            }
        }


    }
}
