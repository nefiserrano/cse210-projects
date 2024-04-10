using System;

public class HexagonShape : Shape
{
    private double _side;
    private double _apothem;

    public HexagonShape(double side, double apothem)
    {
        _side = side;
        _apothem = apothem;
    }

    public override double CalculateArea()
    {
        _area = _perimeter * _apothem / 2;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = 6 * _side;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A hexagon is a six-sided polygon. The apothem of a regular polygon is a line segment from the center to the midpoint of one of its sides.");
    }
}