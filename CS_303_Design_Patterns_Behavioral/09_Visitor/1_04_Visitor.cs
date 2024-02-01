namespace _09_Visitor
{
    // Concrete visitor classes
    public class AreaCalculator : IVisitor
    {
        public void Visit(Circle circle)
        {
            double area = Math.PI * Math.Pow(circle.Radius, 2);
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void Visit(Square square)
        {
            double area = Math.Pow(square.SideLength, 2);
            Console.WriteLine($"Area of Square: {area}");
        }
    }
}
