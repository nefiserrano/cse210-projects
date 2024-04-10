using System;
using System.Reflection.Metadata.Ecma335;

public class RhombusShape : Shape
{
    private double _diagonal1;
    private double _diagonal2;
    private double _side;

    public RhombusShape(double diagonal1, double diagonal2, double side)
    {
        _diagonal1 = diagonal1;
        _diagonal2 = diagonal2;
        _side = side;
    }

    public override double CalculateArea()
    {
        _area = _diagonal1 * _diagonal2 / 2;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = _side * 4;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A rhombus is a quadrilateral with both pairs of opposite sides parallel and all sides the same length.");
    }
}