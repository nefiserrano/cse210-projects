using System;

public class SquareShape : Shape
{
    private double _side;

    public SquareShape(double side)
    {
        _side = side;
    }

    public override double CalculateArea()
    {
        _area = _side * _side;
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = 4 * _side;
        return _perimeter;
    }

    public override void DisplayShapeInformation()
    {
        Console.WriteLine("A square is a regular quadrilateral, which means that it has four sides of equal length and four equal angles.");
    }
}