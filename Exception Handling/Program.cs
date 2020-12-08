using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void streamException()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops");
                // var calculator = new Calculator();
                // var result = calculator.Divide(5, 0);
            }
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine("You cannot divide by 0.");
            // }
            // catch (ArithmeticException ex)
            // {

            // }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally   // alawys executed
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }

        public static void streamExceptionWithUsing()
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip")) // calls the dispose method <- oppose way to creating finally block
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }
    }
}
