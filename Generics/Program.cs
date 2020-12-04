using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dictionary = new GenericDictionary<string, Book>();
            // dictionary.Add("1234", new Book());

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
