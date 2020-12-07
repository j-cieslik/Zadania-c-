using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            
            // LINQ Query Operators
            // var cheaperBooks =
            //     from b in books
            //     where b.Price < 10
            //     orderby b.Title
            //     select b.Title;
        

            books.Single(b => b.Title == "ASP.NET MVC");    // one object

            books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");  //no books match this condition, function returns null
            Console.WriteLine(books == null);    

            var book = books.First(b => b.Title == "C# Advanced Topics");  // First which match 

            books.FirstOrDefault(b => b.Title == "C# Advanced Topics");  // null if no books match

            books.Last(b => b.Title == "C# Advanced Topics"); 

            books.LastOrDefault(b => b.Title == "C# Advanced Topics");  // null if no books match

            var pagedBooks = books.Skip(2).Take(3); // skip 2 object and take 3

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var countOfBooks = books.Count();

            var maxPrice = books.Max(b => b.Price);  
            var minPrice = books.Min(b => b.Price);

            var totalPrices = books.Sum(b => b.Price);

            // books.Where() <- to filter and retun a list of books to match to a given condition
            // books.Single() <- to filter and return a one book
            // books.SingleOrDefault()  <- if don't find book return null

            // books.First()
            // books.FirstOrDefault()
            
            // books.Last()
            // books.LastOrDefault()

            // books.Min()
            // books.Max()
            // books.Count()
            // books.Sum()
            // books.Average(b => b.Price)

            // books.Skip(5).Take(3)

            // LINQ Extension Methods
            // var cheapBooks = books
            //                     .Where(b => b.Price < 10)
            //                     .OrderBy(b => b.Title)
            //                     .Select(b => b.Title);

            // foreach (var book in cheapBooks)
            // {
            //     Console.WriteLine(book);
            // }
        }
    }
}
