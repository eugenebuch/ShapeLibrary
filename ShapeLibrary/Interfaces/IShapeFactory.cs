using ShapeLibrary.Application.Enums;

namespace ShapeLibrary.Application.Interfaces;

public interface IShapeFactory
{
    IShape CreateShape(ShapeEnum shapeType, params double[] parameters);
}