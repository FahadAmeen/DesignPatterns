using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle Class initiated!");
        }
    }
}
