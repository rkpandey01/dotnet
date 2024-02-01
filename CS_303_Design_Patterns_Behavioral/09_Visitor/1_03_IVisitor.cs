namespace _09_Visitor
{
    // Visitor interface
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Square square);
    }
}
