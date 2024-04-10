using System;

public class CircleShape : Shape
{
    private double _radius;

    public CircleShape(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        double pi = Math.PI;
        double squaredRadius = Math.Pow(_radius, 2);
        _area = pi * squaredRadius;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        double pi = Math.PI;
        _perimeter = 2 * pi * _radius;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A circle is a shape consisting of all points in a plane that are at a given distance from a given point, the centre.");
    }
}