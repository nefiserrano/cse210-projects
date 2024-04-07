using System;

public abstract class Shape
{
    protected float _area;
    protected float _perimeter;

    public Shape(float area, float perimeter)
    {
        _area = area;
        _perimeter = perimeter;
    }

    public abstract float CalculateArea();

    public abstract float CalculatePerimeter();

    public void DisplayResults()
    {
        Console.WriteLine($"Area: {_area}, Perimeter: {_perimeter}");
    }
}