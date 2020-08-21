using System;
using Factory_Pattern.Enums;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory=new ShapeFactory();
            var shape1 = factory.GetShape(ShapeTypeEnum.Circle);
            shape1.draw();
            var shape2 = factory.GetShape(ShapeTypeEnum.Square);
            shape2.draw();

        }
    }
}
