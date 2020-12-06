using System;

namespace LambdaExoressions
{

  class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // Predicate is a delegate which points to the method that gets a object (depend on what the method returns) and return the boolean value <-- below is example

            // args => expressions  
            //number => number*number

            // () => ...
            // x => ...
            // (x, y, z) => ...

            // const int factor = 5;

            // Func<int, int> multipler = n => n*factor;

            // var result = multipler(10);
            // Console.WriteLine(result);


            // Func<int, int> square = number => number*number;

            // Console.WriteLine(square(5));
        }

        // the same what that: Func<int, int> square = number => number*number;
        static int Square(int number)
        {
            return number*number;
        }

        // Predicate
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
