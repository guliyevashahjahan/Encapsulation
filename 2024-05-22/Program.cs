namespace _2024_05_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Rich Dad Poor Dad", 7.5, "Motivational",5);
            Book book2 = new Book(2, "Sherlock Holmes", 35, "Mystery",3);
            Book book3 = new Book(3, "To Kill a Mockingbird", 9, "Coming of age",12);
            Book book4 = new Book(4, "The Lord of the Rings", 20.9, "Fantasy",10);
            Book book5 = new Book(5, "Harry Potter", 33.6, "Fantasy",15);

            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);
            Library.AddBook(book4);
            Library.AddBook(book5);

            Book result = Library.GetBookById(1);
            Console.WriteLine($"{result.Id}\n{result.Name}\n{result.Genre}\n{result.Price}\n{result.Count}");

            Book[] filteredBooks = Library.GetFilteredBooks("Fantasy");

            PrintBookData(filteredBooks);

            Book[] filteredBooksByPrice = Library.GetFilteredBooks(9, 34);

            PrintBookData(filteredBooksByPrice);

        }

        static void PrintBookData(Book[] books)
        {
            foreach(Book book in books)
            {

                Console.WriteLine($"{book.Id}\n{book.Name}\n{book.Genre}\n{book.Price}\n{book.Count}\n\n");
            }
        }

    }
}
