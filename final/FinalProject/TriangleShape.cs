using System;

public class TriangleShape : Shape
{
    private double _base;
    private double _height;
    private double _side1;
    private double _side2;

    public TriangleShape(double base1, double height, double side1, double side2)
    {
        _base = base1;
        _height = height;
        _side1 = side1;
        _side2 = side2;
    }

    public override double CalculateArea()
    {
        _area = _base * _height / 2;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = _base + _side1 + _side2;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A triangle is a closed shape with 3 angles, 3 sides, and 3 vertices.");
    }
}