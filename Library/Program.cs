using Library;
using System.Reflection;
using Student = Library.Student;

Book book = new Book("C# for beginners1", "Bill Gates", 12346789);

// This is info for the book class

book.DisplayInfo();  

// Add another book
Book book1 = new Book("Methods and Classes", "Microsoft", 987654321);
Book book2 = new Book("Joshua Clarkson", "OP", 42069);
book1.DisplayInfo();
book2.DisplayInfo();

class Program
{
    static void Main(string[] args)
    {
        // Create a new student using the default constructor
        Student student1 = new Student();
        student1.Display();
        // Create a new student using the custom constructor
        Student student2 = new Student("Alice Smith", 17);
        student2.Display();
        // Create another student using the custom constructor
        Student student3 = new Student("Bob Johnson", 18);
        student3.Display();
        // Display the total number of students created
        Console.WriteLine($"Total number of students: {student1.StudentCount}");
    }
}
