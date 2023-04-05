using System;
using System.Security.Cryptography;
using System.Text;
using Managers;


namespace _005_Book
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new string[][]
            {
                new string[] {"Fist row", "Second row"},
                new string[] {"Long string", "other string", "References"},
                new string[] {"Last string"}
            });
            /*
            book.FindNext("other string");
            book.FindNext("Nothing");
            */
            Book kobzar = new Book(
            new string[][]
            {
                new string[] {"Taras", "Shevchenko"},
                new string[] {"Long string", "other string", "References"},
                new string[] {"Last string"}
            });

           /* FindAndReplaceManager.FindNext("Second row", book);
            FindAndReplaceManager.FindNext("Taras", kobzar);
           */
            kobzar.notes.Add("Love Ukraine");
            kobzar.notes.Print();

            Console.ReadLine();
        }
    }
}
