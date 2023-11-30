using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var Senan = new[] { 1, 2, 3 };
            //var Ilkin = new int[4];

            //Senan.CopyTo(Ilkin, 0);

            //foreach (int item in Ilkin)
            //{
            //    Console.WriteLine(item);
            //}

            //Book book = new Book("Test1");
            //Book book1 = new Book("Test 2");
            //Book book2 = new Book("Test 3");

            //Console.WriteLine(book.No + " " +book.Name);
            //Console.WriteLine(book1.No + " " + book.Name);
            //Console.WriteLine(book2.No + " " + book.Name);

            Library library = new Library();
            Book book = new Book("Hello");
            Book book3 = new Book("Hello3");
            Book book2 = new Book("Bye");


            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);

            foreach (Book item in library.books)
            {
                //Console.WriteLine($"No: {item.No}\nName: {item.Name}\n");
            }

            foreach (Book item in library.FindAllBooksByName("Hello"))
            {
                Console.WriteLine(item.No + " " + item.Name);
            }


        }



    }
    class Book
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        private static int _no;

        public Book(string name)
        {
            Name = name;
            No = ++_no;
        }

    }
    class Library
    {

        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);

        }
        public List<Book> FindAllBooksByName(string name)
        {
           

            List<Book> result = books.Where(x => x.Name.Contains(name)).ToList();

            return result;
        }
    }
}
