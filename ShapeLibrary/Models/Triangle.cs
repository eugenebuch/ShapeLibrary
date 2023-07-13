using ShapeLibrary.Application.Interfaces;

namespace ShapeLibrary.Application.Models;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        (SideA, SideB, SideC) = (sideA, sideB, sideC);
    }

    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle() => Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) < 0.0001;
}