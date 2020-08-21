using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle Class initiated!");
        }
    }

}
