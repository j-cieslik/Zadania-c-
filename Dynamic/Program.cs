using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Kuba";
            name = 1;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; // var is dynamic

            int i = 5;
            dynamic d = i;
            
        }
    }
}
