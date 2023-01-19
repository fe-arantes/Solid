using Application.ValueObjects;
using Application.ValueObjects.Common;
using System.Drawing;

namespace Application.Services;

public class GeometryServices
{
    private double AreaWrong(object[] shapes)
    {
        double area = 0;

        foreach ( var shape in shapes )
        {
            if ( shape is Rectangle )
            {
                var rectangle = (Rectangle)shape;
                area += rectangle.Width * rectangle.Height;
            }

            if ( shape is Circle )
            {
                var circle = (Circle)shape;
                area += circle.Radius * circle.Radius * Math.PI;
            }
        }

        return area;
    }

    public double GetRectangleArea(Rectangle[] shapes)
    {
        double area = 0;

        foreach ( var shape in shapes )
        {
            area += shape.Width * shape.Height;
        }

        return area;
    }

    private double Area(Shape[] shapes)
    {
        double area = 0;

        foreach ( var shape in shapes )
        {
            area += shape.Area();
        }

        return area;
    }
}
