﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4C_
{
    public delegate string BookFunction(Book book);

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title; 
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            return $"ISBN: {ISBN} \n" +
                   $"Title: {Title} \n" +
                   $"Authors: {string.Join(", ", Authors)} \n" +
                   $"Publication Date: {PublicationDate} \n" +
                   $"Price: {Price} \n";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }

    //public class LibraryEngine
    //{
    //    public static void ProcessBooks(List<Book> bList, BookFunction fPtr)

    //    {
    //        foreach (Book B in bList)
    //        {
    //            Console.WriteLine(fPtr(B));
    //        }
    //    }
    //}
}
