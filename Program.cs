using System;
using Project4C_;

namespace Project3C_
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book> { 
                new Book("12345", "C# Basics", new string[] { "John Doe", "Jane Smith" }, DateTime.Now.AddMonths(-6), 29.99m),
                new Book("67890", "Advanced C# Programming", new string[] { "Alice Brown" }, DateTime.Now.AddMonths(-12), 49.99m),
                new Book("11223", "C# for Beginners", new string[] { "Michael Lee", "Sarah Clark" }, DateTime.Now.AddMonths(-2), 19.99m),
                new Book("44556", "Mastering C#", new string[] { "David Wilson" }, DateTime.Now.AddMonths(-24), 59.99m),
                new Book("78901", "C# Data Structures", new string[] { "Emily Johnson", "Robert White" }, DateTime.Now.AddMonths(-18), 39.99m),
            };


            BookFunction myDelegate = BookFunctions.GetTitle;
            Console.WriteLine("User Defined Delegate (GetTitle):");
            foreach (var book in books)
            {
                Console.WriteLine(myDelegate.Invoke(book));
            }


            Func<Book, string> bclDelegate = BookFunctions.GetAuthors;
            Console.WriteLine("\nBCL Delegate (GetAuthors):");
            foreach (var book in books)
            {
                Console.WriteLine(bclDelegate.Invoke(book));
            }


            Func<Book, string> anonymousDelegate = delegate (Book b) { return b.ISBN; };
            Console.WriteLine("\nAnonymous Method (GetISBN):");
            foreach (var book in books)
            {
                Console.WriteLine(anonymousDelegate.Invoke(book));
            }


            Func<Book, string> lambdaDelegate = b => b.PublicationDate.ToString("yyyy-MM-dd");
            Console.WriteLine("\nLambda Expression (GetPublicationDate):");
            foreach (var book in books)
            {
                Console.WriteLine(lambdaDelegate.Invoke(book));
            }
        }
    }
}
