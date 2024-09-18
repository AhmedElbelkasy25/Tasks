namespace task3
{
    class Book {
        public string title;
        public string auther;
        public string ISBN;
        public bool availability = true;
        

        public Book(string title, string auther, string iSBN)
        {
            this.title = title;
            this.auther = auther;
            ISBN = iSBN;
            
        }
    }
    class Library { 
        public List<Book> books=new List<Book>();
        public void AddBook(Book book ){
        books.Add(book);
        }

        public void BorrowBook( string searchedTitle) {
            for (int i = 0; i < books.Count; i++) {
                if (books[i].title.Contains(searchedTitle) && books[i].availability)
                {
                    books[i].availability = false;
                    Console.WriteLine("done...");
                    return;
                }
                else if (books[i].title.Contains(searchedTitle) && !books[i].availability)
                {
                    Console.WriteLine($"{searchedTitle} is borrowed");
                    return;
                }              
            }
            Console.WriteLine($"{searchedTitle} is not in the library");
        }
        public void ReturnBook(string returnedBook) {
            for (int i = 0; i < books.Count; i++) {
                if (books[i].title.Contains(returnedBook) && !books[i].availability)
                {
                    books[i].availability = true;
                    Console.WriteLine($"this book \"{books[i].title}\" have been returned successfully");
                    return;
                }
                else if (books[i].title.Contains(returnedBook) && books[i].availability)
                {
                    Console.WriteLine($"this book\"{books[i].title}\" is not borrowed");
                    return;
                }   
            }
            Console.WriteLine($"this book \"{returnedBook}\" is not exist");
        }
        public string SearchForBook(string title) {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title)
                {
                    Console.WriteLine($"this book \" {books[i].title}\" is exist");
                    return books[i].title;
                }
            }
            return "this book is not exist in the library";
            
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));



            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

           

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

          


        }
    }
}
