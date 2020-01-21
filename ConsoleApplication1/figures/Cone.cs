using System;

namespace ConsoleApplication1.figures
{
    public class Cone: Circle
    {
        public int Height { get; set; }

        public Cone(int x, int y, int radius, int height) : base(x, y, radius)
        {
            Height = height;
        }

        public double GetVolume()
        {
            return GetArea() * Height / 3;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}