using System;

namespace Coding.Exercise
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {

        public double Radius { get; private set; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectengle : IShape
    {

        public double Width { get; private set; }
        public double Height { get; private set; }
        
        public Rectengle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        
        public double GetArea()
        {
            return Width * Height;
        }
    }
    
    
    public class Exercise
    {
        public void PrintAreas()
        {
            IShape[] shapes = new IShape[] { new Circle(5), new Rectengle(5,3) };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area: " + shape.GetArea());
            }
        }
    }
}