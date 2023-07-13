using ShapeLibrary.Application.Enums;
using ShapeLibrary.Application.Interfaces;
using ShapeLibrary.Application.Models;

namespace ShapeLibrary.Application;

public class ShapeFactory : IShapeFactory
{
    public IShape CreateShape(ShapeEnum shapeType, params double[] parameters)
    {
        if (parameters.Any(x => x <= 0) || !parameters.Any())
            throw new ArgumentException($"{nameof(parameters)} sequence contains not supported values");

        return shapeType switch
        {
            ShapeEnum.Circle => parameters.Length == 1
                ? new Circle(parameters[0])
                : throw new ArgumentException("Incorrect parameters count"),
            ShapeEnum.Triangle => parameters.Length == 3
                ? new Triangle(parameters[0],
                    parameters[1],
                    parameters[2])
                : throw new ArgumentException("Incorrect parameters count"),
            _ => throw new ArgumentException("Invalid shape type.")
        };
    }
}