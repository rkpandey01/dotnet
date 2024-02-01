namespace _05_Prototype
{
    public class Square : Shape
    {
        private int sideLength;

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }

        public override IShape Clone()
        {
            // Create a shallow copy of the current object
            return this.MemberwiseClone() as IShape;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a square with side length {sideLength}");
        }
    }
}
