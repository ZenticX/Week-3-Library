using Library;
using System.Reflection;

Book book = new Book("C# for beginners", "Bill Gates", 12346789);

// This is info for the book class

book.DisplayInfo();  

// Add another book
Book book1 = new Book("Methods and Classes", "Microsoft", 987654321);
Book book2 = new Book("Joshua Clarkson", "OP", 42069);
book1.DisplayInfo();
book2.DisplayInfo();