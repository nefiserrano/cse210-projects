using System;
using System.Threading.Tasks.Dataflow;

public class RectangleShape : Shape
{
    private double _width;
    private double _length;

    public RectangleShape(double width, double length)
    {
        _width = width;
        _length = length;
    }

    public override double CalculateArea()
    {
        _area = _width * _length;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = 2 * (_width + _length);
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("The opposite sides of a rectangle (width and length) are equal and parallel.");
    }
}