namespace SOLIDExample
{
    using System;

    // SOLID Principles:

    // Single Responsibility Principle (SRP): A class should have only one reason to change.
    // Open-Closed Principle (OCP): Software entities should be open for extension but closed for modification.
    // Liskov Substitution Principle (LSP): Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.
    // Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they do not use.
    // Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules. Both should depend on abstractions.

    // Example: A simple console application for calculating the area of different shapes (circle, rectangle, square).

    // Shape interface representing a shape with an Area method.
    public interface IShape
    {
        double Area();
    }

    // Circle class implementing the Shape interface.
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class implementing the Shape interface.
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }

    // Square class implementing the Shape interface.
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double Area()
        {
            return SideLength * SideLength;
        }
    }

    // Application class for calculating and displaying the areas of different shapes.
    public class AreaCalculator
    {
        private readonly IShape[] _shapes;

        public AreaCalculator(IShape[] shapes)
        {
            _shapes = shapes;
        }

        public void CalculateAndDisplayAreas()
        {
            foreach (var shape in _shapes)
            {
                double area = shape.Area();
                Console.WriteLine($"Area: {area}");
            }
        }
    }

    // Main program entry point.
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an array of different shapes.
            IShape[] shapes = {
            new Circle(5),
            new Rectangle(3, 4),
            new Square(2)
        };

            // Create an instance of the AreaCalculator and pass the shapes array.
            AreaCalculator calculator = new AreaCalculator(shapes);

            // Calculate and display the areas of the shapes.
            calculator.CalculateAndDisplayAreas();
        }
    }

}