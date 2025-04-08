using System;
using System.Security.Cryptography.X509Certificates;
public class LibraryApp
{
    public static void MainLibraryEngine(string[] args)
    {
        List<Book> books = new List<Book>();
        int id = 1;
        while (true)
        {
            mainMenu();
            int selection = checkSelection();
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Enter book title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter book author:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book year:");
                    string year = Console.ReadLine();
                    if (comfirmPrompt(title, author, year))
                    {
                        books.Add(new Book(id++, title, author, int.Parse(year)));
                        Console.WriteLine("Book added successfully!");
                    }
                    break;
                case 2:
                    Console.WriteLine("All books in the library:");
                    foreach (var book in books)
                    {
                        Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter book title to search:");
                    string searchTitle = Console.ReadLine();
                    var foundBooks = books.Where(b => b.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (foundBooks.Count > 0)
                    {
                        Console.WriteLine("Found books:");
                        foreach (var book in foundBooks)
                        {
                            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No books found with that title.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter book ID to delete:");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        var bookToDelete = books.FirstOrDefault(b => b.Id == deleteId);
                        if (bookToDelete != null)
                        {
                            books.Remove(bookToDelete);
                            Console.WriteLine("Book deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("No book found with that ID.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
    public static void mainMenu()
    {
        Console.WriteLine("-=====-=====-=====-=====-=====-\n");
        Console.WriteLine("Welcome to the Library App!");
        Console.WriteLine("1. Add a book");
        Console.WriteLine("2. View all books");
        Console.WriteLine("3. Search for a book");
        Console.WriteLine("4. Delete for a book by id");
        Console.WriteLine("0. Exit");
        Console.Write("Please select an option \n\n");
        Console.WriteLine("-=====-=====-=====-=====-=====-");
    }
    public static int checkSelection()
    {
        int selection;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out selection) && selection >= 0 && selection <= 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
            }
        }
        return selection;
    }
    public static bool comfirmPrompt(string title, string author, string year)
    {
        if(title.GetType().Name == "String" && title.Length <= 30)
        {
            if (author.GetType().Name == "String" && author.Length <= 50)
            {
                if (int.TryParse(year, out _) && year.Length >= 3 && year.Length <= 4)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Year must be an integer. and 4 simbol");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Author must be a string. and less then 50 letter.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Title must be a string. and less than 30 letter");
            return false;
        }
    }
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }
    }
}