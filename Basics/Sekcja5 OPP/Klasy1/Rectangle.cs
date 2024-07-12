using System;
using System.Drawing;

namespace Klasy1
{
    internal class Rectangle
    {
        private readonly int _id;
        private static int _nextId;
        
        public int Id => _id;

        // Stała, której nie da się zmienić
        public const int NumberOfCorners = 4;

        private int _area;
        public int Area => _area;

        public readonly string Color;
        
        public int Width { get; }
        public int Height { get;  }

        public Rectangle(int height, int width, string color)
        {
            _id = _nextId++;
            Color = color;
            Width = width;
            Height = height;
            _area = Width * Height;
            
            Console.WriteLine($"id: {_id}");
            Console.WriteLine($"Width = {Width}, Height = {Height}, Area = {Area}, Color = {Color}, Number of corners: {NumberOfCorners}");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing rectangle with width: {Width}, height: {Height}, color: {Color}");
        }
    }
}