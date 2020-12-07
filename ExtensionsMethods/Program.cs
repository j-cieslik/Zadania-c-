using System;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a long blog blah blah blah blah balah ...";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }

}
