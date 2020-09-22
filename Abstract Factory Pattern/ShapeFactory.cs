using Factory_Pattern.Enums;

namespace Factory_Pattern
{
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypeEnum type)
        {
            switch (type)
            {
                case ShapeTypeEnum.Circle:
                    return new Circle();
                case ShapeTypeEnum.Square:
                    return new Square();
                case ShapeTypeEnum.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}