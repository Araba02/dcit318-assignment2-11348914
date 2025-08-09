using System;

namespace AbstractDemo
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea() => Width * Height;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");

            Shape circle = new Circle(3.5);
            Shape rectangle = new Rectangle(4, 5);

            Console.WriteLine($"Circle (r=3.5) area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle (w=4, h=5) area: {rectangle.GetArea():F2}");
        }
    }
}
