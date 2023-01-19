using Application.ValueObjects.Common;

namespace Application.ValueObjects;

public class RectangleObject : Shape
{
    public double Width { get; }
    public double Height { get; }

    private RectangleObject(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public static RectangleObject Create(double width, double height)
    {
        return new(width, height);
    }

    public override double Area()
    {
        return Width * Height;
    }
}
