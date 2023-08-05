# Phil's Lending Library

**Author**: Mollemira Porphura
**Version**: 1.0.0

## Overview
Phil's Lending Library is a console application that simulates a lending library with the ability to add books, view the library's collection, borrow books, return books, and view the books in the your backpack.

## Getting Started
To build and run this application on your own machine, follow these steps:
1. Clone this repository to your local machine using the command: `git clone https:github.com/MollyAP/Lab-08-Library.git`
2. Navigate to the `Lab-08-Library` folder.
3. Open the solution file `Lab-08-Library.sln` in Visual Studio or your preferred C# development environment.
4. Build the solution to resolve any dependencies and compile the code.
5. Run the application by executing the `Program.cs` file.

## Example
Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

1
Library Books:
Homestuck by Andrew Hussie, 8123 pages
dead dead demon's dededede destruction vol 1 by Inio Asano, 196 pages

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

2
Enter the title of the book:
My Diary
Enter the author's first name:
Mollemira
Enter the author's last name:
Porphura
Enter the number of pages:
500
Book added to the library.

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

1
Library Books:
Homestuck by Andrew Hussie, 8123 pages
dead dead demon's dededede destruction vol 1 by Inio Asano, 196 pages
My Diary by Mollemira Porphura, 500 pages

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

3
Enter the title of the book to borrow:
My Diary
You have borrowed My Diary.

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

1
Library Books:
Homestuck by Andrew Hussie, 8123 pages
dead dead demon's dededede destruction vol 1 by Inio Asano, 196 pages

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

4
Enter the number of the book to return:
1
You have returned My Diary.

Hello! Welcome to my Library
Pick an option:
1: View Books
2: Add Book
3: Check out Book
4: Return Book
5: Exit

1
Library Books:
Homestuck by Andrew Hussie, 8123 pages
dead dead demon's dededede destruction vol 1 by Inio Asano, 196 pages
My Diary by Mollemira Porphura, 500 pages

## Architecture
The application is built using C# and consists of the following classes:
- `Book`: Represents a book with properties like title, author, and number of pages.
- `Library`: Implements the `ILibrary` interface to manage the collection of books. It uses a private dictionary to store books.
- `Backpack`: Implements the `IBag<Book>` interface to hold borrowed books. It uses a private list to store books.
- `Program`: Contains the main method and serves as the user interface to interact with the library and backpack.

The application uses the .NET framework and C# language. It includes interfaces (`ILibrary` and `IBag`) to define the required functionality for the library and backpack. The code follows object-oriented design principles, and collections are used for data storage and management.

## Change Log
- 07/31/2023 12:58 PM: Initial version of the application with basic library and backpack functionality.
- 07/31/2023 03:24 PM: Implemented `ToString()` method in the `Book` class for better book representation.
- 07/31/2023 05:17 PM: Updated `AddBook` method to fix argument issue when adding books to the library.
- 07/31/2023 06:32 PM: Updated `ReturnBook` method to use correct comparison for book number in the backpack.
- 07/31/2023 07:10 PM: Updated README to include project overview, getting started, example, and architecture information.

