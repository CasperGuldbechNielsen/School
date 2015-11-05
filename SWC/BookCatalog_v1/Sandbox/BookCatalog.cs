using System;
using System.Collections.Generic;

namespace Sandbox
{
    class BookCatalog
    {
        private List<Book> books;

        public BookCatalog()
        {
            books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            books.Add(aBook);
        }

        public void PrintAllBooks()
        {
            foreach (Book element in books)
            {
                Console.WriteLine(element.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            foreach (Book element in books)
            {
                if (element.GetISBN() == isbn)
                {
                    matchingBook = element;
                }
            }

            return matchingBook;
        }
    }
}
