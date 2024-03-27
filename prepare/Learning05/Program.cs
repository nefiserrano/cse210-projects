using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 10);

        Rectangle rectangle = new Rectangle("red", 5, 20);

        Circle circle = new Circle("green", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}