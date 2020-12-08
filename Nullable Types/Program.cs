using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime date = null  <- it can't be, DateTime is value type

            // Nullable<DateTime> date = null;

            // DateTime? date2 = null;   // shorter form 

            // Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            // Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value: " + date.Value); // throws an exception if value = null

            // DateTime? date = new DateTime(2014, 1, 1);
            // DateTime date2 = date.GetValueOrDefault();

            // DateTime? date3 = date2;

            DateTime? date = null;
            DateTime date2;

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;


            DateTime date3 = date ?? DateTime.Today; //the same what above

            DateTime date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;


            DateTime? date18 = null;

            System.Console.WriteLine(date18.Value); //exception
            System.Console.WriteLine(date18.GetValueOrDefault()); // no exception

        }
    }
}
