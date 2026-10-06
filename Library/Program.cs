using Library;

Book book = new Book();

// This is info for the book class
book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN = 12346789;

book.DisplayInfo();  

// Add another book
Book book1 = new Book();
book1.Title = "Methods and Classes";
book1.Author = "Microsoft";
book1.ISBN = 987654321;
book1.DisplayInfo();