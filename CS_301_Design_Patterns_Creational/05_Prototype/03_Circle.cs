using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Prototype
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override IShape Clone()
        {
            // Create a shallow copy of the current object
            return this.MemberwiseClone() as IShape;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }
    }

}
