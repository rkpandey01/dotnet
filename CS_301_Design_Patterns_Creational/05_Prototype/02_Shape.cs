namespace _05_Prototype
{
    public abstract class Shape : IShape
    {
        public abstract IShape Clone();

        public abstract void Draw();
    }
}
