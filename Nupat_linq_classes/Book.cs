using System;
using System.Collections.Generic;
using System.Linq;



namespace Nupat_linq_classes
{
    internal class Book
    {

        public string title;
        public string Author;
        public int publishYear;
        public string Genre;



        public Book(string aTitle, string aAuthor, int apublishYear, string aGenre)
        {
            title = "atitle";
            Author = "aauthor";
            publishYear = apublishYear;
            Genre = "aGenre";
        }




        static void main()

        {
            List<Book> books = new List<Book>
        {
            new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, "Fantasy"),
            new Book("To Kill a Mockingbird", "Harper Lee", 1960, "Fiction"),
            new Book("1984", "George Orwell", 1949, "Science Fiction"),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Classic"),
            new Book("Pride and Prejudice", "Jane Austen", 1813, "Romance")
        };






        }
          


        
    }



  


} 
