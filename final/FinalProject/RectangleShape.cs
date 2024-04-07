using System;

public class RectangleShape : Shape
{
    private float _width;
    private float _length;

    public RectangleShape(float area, float perimeter, float width, float length) : base (area, perimeter)
    {
        _width = width;
        _length = length;
    }

    public override float CalculateArea()
    {
        _area = _width * _length;
        return _area;
    }

    public override float CalculatePerimeter()
    {
        _perimeter = 2 * (_width + _length);
        return _perimeter;
    }
}