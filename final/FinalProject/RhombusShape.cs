using System;

public class RhombusShape : Shape
{
    private float _diagonal1;
    private float _diagonal2;
    private float _side;

    public RhombusShape(float area, float perimeter, float diagonal1, float diagonal2, float side) : base (area, perimeter)
    {
        _diagonal1 = diagonal1;
        _diagonal2 = diagonal2;
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