using System;
using System.Collections.Generic;

namespace polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Select();
            rectangle.Copy();
        }
    }
}
