using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("- Ex1.2 (Circle): ");
            Circle circle1 = new Circle(5.0);
            Console.WriteLine(circle1);
            Console.WriteLine("Area = " + circle1.Area());
            Console.WriteLine("Circumference = " + circle1.Circumference());

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.WriteLine("- Ex1.4 (Employee): ");
            Employee employee1 = new Employee(1, "John", "Smith", 1000);
            Console.WriteLine(employee1);
            Console.WriteLine("Annual Salary: " + employee1.AnnualSalary());
            Console.WriteLine("Raise Salary: " + employee1.RaiseSalary(10));

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.WriteLine("- Ex2.1 (Author): ");
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            Console.WriteLine(ahTeck); // Test ToString()
            ahTeck.Email = "paulTan@nowhere.com"; // Test setter
            Console.WriteLine("Name is: " + ahTeck.Name); // Test getter
            Console.WriteLine("Email is: " + ahTeck.Email); // Test getter
            Console.WriteLine("Gender is: " + ahTeck.Gender);

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.WriteLine("- Ex2.1 (Book 1-1): ");
            Author ahTeck1 = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            Console.WriteLine(ahTeck1); // Author's ToString()
            Book_1_1 dummyBook = new Book_1_1("Java for dummy", ahTeck1, 19.95, 99); // Test Book's Constructor
            Console.WriteLine(dummyBook); // Test Book's ToString()
            // Test Getters and Setters
            dummyBook.Price = 29.95;
            dummyBook.Qty = 28;
            Console.WriteLine("Name is: " + dummyBook.Name);
            Console.WriteLine("Price is: " + dummyBook.Price);
            Console.WriteLine("Qty is: " + dummyBook.Qty);
            Console.WriteLine("Author is: " + dummyBook.Author); // Author's ToString()
            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);
            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);
            // Use an anonymous instance of Author to construct a Book instance
            Book_1_1 anotherBook = new Book_1_1("more Java",
            new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            Console.WriteLine(anotherBook); // ToString()

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.WriteLine("- Ex2.2 (Book 1-n): ");
            // Declare and allocate an array of Authors
            Author[] authors = new Author[2];
            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');
            // Declare and allocate a Book instance
            Book_1_n javaDummy = new Book_1_n("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy); // ToString()
        }
    }
}
