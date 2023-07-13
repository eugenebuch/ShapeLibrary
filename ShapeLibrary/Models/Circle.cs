using ShapeLibrary.Application.Interfaces;

namespace ShapeLibrary.Application.Models;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;
}