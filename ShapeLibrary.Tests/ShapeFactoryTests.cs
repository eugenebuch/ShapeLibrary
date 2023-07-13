using ShapeLibrary.Application;
using ShapeLibrary.Application.Enums;
using ShapeLibrary.Application.Models;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeFactoryTests
    {
        [Test]
        public void CalculateTotalArea_ShouldReturnCorrectTotalArea()
        {
            // Arrange
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.CreateShape(ShapeEnum.Circle, 5);
            var triangle = shapeFactory.CreateShape(ShapeEnum.Triangle, 3, 4, 5);

            // Act
            var circleArea = circle.CalculateArea();
            var triangleArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(78.5398, circleArea, 0.0001);
            Assert.AreEqual(6, triangleArea, 0.0001);
        }

        [Test]
        public void CalculateTotalArea_ShouldThrowArgumentException()
        {
            // Arrange
            var shapeFactory = new ShapeFactory();

            // Assert
            Assert.Throws<ArgumentException>(() => shapeFactory.CreateShape(ShapeEnum.Circle, 5, 2));
        }
    }
}