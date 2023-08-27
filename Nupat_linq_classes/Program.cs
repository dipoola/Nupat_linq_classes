using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace Nupat_linq_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");

             int[] arrayNum = { 267, 2720, 30, 3094, 23, 45, 34, 24, 22 };

             var orderAsc = from queryTo in arrayNum
                            where queryTo > 10
                            select queryTo;

             var orderDecs = from holdsDesc in arrayNum
                             orderby holdsDesc descending
                             select holdsDesc;  */


            //Linq 
            /* int[] arrayNum = { 267, 2720, 30, 3094, 23, 45, 34, 24, 22 };

           var orderDecs = from holdsDesc in arrayNum
                           orderby holdsDesc descending
                           select holdsDesc;
           foreach (var item in orderDecs)
           {
               Console.WriteLine(item);
           }
                   Console.ReadLine(); */

            /*  List<string> novels= new List<string>();
              novels.Add("lagos");
              novels.Add("Abia");
              novels.Add("Abakaliki");
              novels.Add("oyo");
              novels.Add("Abeokuta");
              novels.Add("osun");
            */
            /*  for(int i = 0; i < novels.Count; i++)
             {
                 Console.WriteLine(novels[i]);
             }    Console.ReadLine();*/

            /*  foreach(var novel in novels)
            {
                Console.WriteLine(novel);
            }    Console.ReadLine(); */

            /*  Assignment */

            /* Book book1= new Book("the chronicle of Nupat", "Dipps" , 2023, "Practical");
              book1.title = "the chronicle of Nupat";
              book1.Author = " Dipps";
              book1.publishYear = 2023;
              book1.Genre = "Practicals";


             Console.WriteLine(book1.title);
              Console.ReadLine();   */




             /* var orderAsc = from queryTo in arrayNum
                           orderby queryTo ascending
                           select queryTo; */



            List<Book> book = new List<Book>
          {
          new Book
               {
                    Title = "Harry Potter and the sorcerrers stone",
                    Author = "J K Rowlins",
                    PublishYear = 1997,
                    Genre = "Fantasy",
               },
               new Book
               {
                   Title="To kill a Monkey Bird",
                   Author = "Harper Lee",
                   PublishYear = 1960,
                   Genre = "Fiction"
               },
               new Book
               {
                   Title= "Pride and prejudice",
                   Author = "George Owell",
                   PublishYear = 1813,
                   Genre = "Romance"
               },
               new Book
               {
                   Title = "1984",
                   Author = "George Owell",
                   PublishYear = 1949,
                   Genre = "Science Fiction"
               },
               new Book
               {
                   Title = "The great gatsby",
                   Author = "F. Scott",
                   PublishYear = 1925,
                   Genre = "Classic"
               }

            };


              DisplayOldestbook();
            //DisplayTitleAfterYear();


            void DisplayTitleAfterYear()
            {
                var targetedYear = from holder in book
                                   where holder.PublishYear > 1940

                                   select holder;

                foreach (var item in targetedYear)
                {
                    Console.WriteLine($"This are the titles whose year are greater than 1940{item.Title}");
                }

            }

            void DisplayOldestbook()
            {
                var olderBook = book
                            .OrderBy
                            (book => book.PublishYear).First();
                Console.WriteLine($"The oldest book in the colection is {olderBook.Title} " +
                    $"the year is {olderBook.PublishYear}");
            }


            void GroupByAuthor()
            {
                var filter = book
                    .GroupBy(books => books.Author)
                    .Select(rend => new
                    {
                        Author = rend.Key,
                        Count = rend.Count()
                    });
                foreach (var item in filter)
                {
                    Console.WriteLine($"{item.Author}: {item.Count}");
                }

            }



            void LongestTitle()
            {
                var filter = book
                    .OrderByDescending(book => book.Title.Length).First();


                Console.WriteLine($"The longest Title of the books is {filter.Title}");
                     Console.ReadLine();
            }


            void AveragePublicationYear()
            {
                var filter = book.Average(x => x.PublishYear);
                Console.WriteLine($"The average of PublicationYear is {filter}");


            }


               
              

        }


        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int PublishYear { get; set; }
            public string Genre { get; set; }
        }


    }








    ////foreach (var item in orderDecs)
    ////{
    ////    Console.WriteLine(item);
    ////}
    ///








    //string[] arrayStrings =
    //{
    //        "Tomi Liys", "Sh ola", "Salako", "Shomolu",
    //        "Abuja", "Lag os", "Nupat", "NIT"
    //    };

    //var filter = from selectA in arrayStrings
    //             where selectA.Contains(" ")
    //             select selectA;

    //    foreach (var array in filter)
    //    {
    //        Console.WriteLine(array);
    //    }





    //Console.ReadLine();  







     



}
