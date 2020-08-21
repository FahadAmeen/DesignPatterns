using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Square Class initiated!");
        }
    }
}
