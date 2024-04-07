using System;

public class SquareShape : Shape
{
    private float _side;

    public SquareShape(float area, float perimeter, float side) : base (area, perimeter)
    {
        _side = side;
    }

    public override float CalculateArea()
    {
        return 0;
    }

    public override float CalculatePerimeter()
    {
        return 0;
    }
}