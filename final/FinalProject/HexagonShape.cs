using System;

public class HexagonShape : Shape
{
    private float _side;
    private float _apothem;

    public HexagonShape(float area, float perimeter, float side, float apothem) : base (area, perimeter)
    {
        _side = side;
        _apothem = apothem;
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