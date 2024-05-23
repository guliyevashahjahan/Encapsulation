using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22
{
    public class Library
    {
        static private Book[] _books = Array.Empty<Book>();
        public static void AddBook(Book book) 
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length-1] = book;
        }
        public static Book GetBookById(int id)
        {
            Book book = _books[0];
            foreach (var item in _books)
            {
                if (item.Id == id)
                {
                    book = item;
                }
            }
            return book;
        }
        public static Book GetBookByName(string name)
        {
            Book book = _books[0];
            foreach (var item in _books)
            {
                if (item.Name == name)
                {
                    book = item;
                }
            }
            return book;
        }
        public static Book[] GetFilteredBooks (string genre)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in _books)
            {
                if (book.Genre == genre)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            return filteredBooks;
        }

        public static Book[] GetFilteredBooks (int minPrice, int maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in _books)
            {
                if (book.Price >= minPrice &&  book.Price <= maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            return filteredBooks;
        }

    }
}
