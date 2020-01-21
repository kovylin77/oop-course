using System;
using ConsoleApplication1.figures;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cone cone = new Cone(34, 45, 15, 38);

            cone.MovePointBy(12, 54);
            Console.WriteLine($"Current point: x = {cone.X}, y = {cone.Y}");
            Console.WriteLine($"Circle area is {cone.GetArea()}");
            Console.WriteLine($"Cone base perimeter is {cone.GetPerimeter()}");
            Console.WriteLine($"Cone volume is {cone.GetVolume()}");
            Console.WriteLine($"Current class name is {cone.GetClassName()}");
        }
    }
}