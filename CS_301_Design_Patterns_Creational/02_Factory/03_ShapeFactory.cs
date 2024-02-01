namespace _02_Factory
{
    internal class ShapeFactory
    {
        // Factory method
        public IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }

            shapeType = shapeType.ToLower();

            switch (shapeType)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
