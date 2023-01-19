using Application.ValueObjects.Common;

namespace Application.ValueObjects;

public class CircleObject : Shape
{
    public double Radius { get; }

    private CircleObject(double radius)
    {
        Radius = radius;
    }

    public static CircleObject Create(double radius)
    {
        return new(radius);
    }

    public override double Area()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}

