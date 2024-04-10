using System;

public class TrapezoidShape : Shape
{
    private double _base1;
    private double _base2;
    private double _height;
    private double _side1;
    private double _side2;

    public TrapezoidShape(double base1, double base2, double height, double side1, double side2)
    {
        _base1 = base1;
        _base2 = base2;
        _height = height;
        _side1 = side1;
        _side2 = side2;
    }

    public override double CalculateArea()
    {
        _area = (_base1 + _base2) / 2 * _height;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = _base1 + _base2 + _side1 + _side2;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A trapezoid is a quadrilateral that has at least one pair of parallel sides. The parallel sides are called the bases.");
    }
}