namespace _09_Visitor
{
    // Shape interface
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
