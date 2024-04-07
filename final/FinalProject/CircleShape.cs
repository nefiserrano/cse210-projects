using System;

public class CircleShape : Shape
{
    private float _radius;

    public CircleShape(float area, float perimeter, float radius) : base (area, perimeter)
    {
        _radius = radius;
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