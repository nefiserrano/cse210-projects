using System;

public abstract class Shape
{
    protected double _area;
    protected double _perimeter;

    public Shape()
    {
        _area = 0;
        _perimeter = 0;
    }

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public abstract void DisplayShapeInformation();

    public void DisplayResults()
    {
        Console.WriteLine("");
        Console.WriteLine($"Area: {_area}, Perimeter: {_perimeter}");
    }
}