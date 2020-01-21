using System;

namespace ConsoleApplication1.figures
{
    public class Circle: Point
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * (Radius ^ 2);
        }
    }
}