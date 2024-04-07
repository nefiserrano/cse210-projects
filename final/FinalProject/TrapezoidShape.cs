using System;

public class TrapezoidShape : Shape
{
    private float _base1;
    private float _base2;
    private float _height;
    private float _side1;
    private float _side2;

    public TrapezoidShape(float area, float perimeter, float base1, float base2, float height, float side1, float side2) : base (area, perimeter)
    {
        _base1 = base1;
        _base2 = base2;
        _height = height;
        _side1 = side1;
        _side2 = side2;
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