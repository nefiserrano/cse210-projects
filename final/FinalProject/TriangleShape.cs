using System;

public class TriangleShape : Shape
{
    private float _base;
    private float _height;
    private float _side1;
    private float _side2;

    public TriangleShape(float area, float perimeter, float base1, float height, float side1, float side2) : base (area, perimeter)
    {
        _base = base1;
        _height = height;
        _side1 = side1;
        _side2 = side2;
    }

    public override float CalculateArea()
    {
        _area = _base * _height / 2;
        return _area;
    }

    public override float CalculatePerimeter()
    {
        _perimeter = _base + _side1 + _side2;
        return _perimeter;
    }
}